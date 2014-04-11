﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;
using GX;
using System.Xml.Linq;

public static partial class Extensions
{
	#region Random
	private static readonly System.Random random = new System.Random();

	/// <summary>
	/// 得到随机的bool值
	/// </summary>
	/// <param name="random"></param>
	/// <param name="successRate">胜率，返回结果有该概率为true</param>
	/// <returns></returns>
	public static bool Next(this System.Random random, double successRate)
	{
		return successRate > random.NextDouble();
	}

	/// <summary>
	/// 从序列中随机选择一个元素
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="list"></param>
	/// <returns>失败返回<c>default(T)</c></returns>
	public static T Random<T>(this IList<T> list)
	{
		if (list == null || list.Count == 0)
			return default(T);
		return list[random.Next(list.Count)];
	}
	#endregion

	#region Enumerable
	public static IEnumerable<object> AsEnumerable(this IEnumerator it)
	{
		if (it == null)
			yield break;
		while (it.MoveNext())
			yield return it.Current;
	}

	public static IEnumerable<T> AsEnumerable<T>(this IEnumerator<T> it)
	{
		if (it == null)
			yield break;
		while (it.MoveNext())
			yield return it.Current;
	}

	public static void AddRange<TKey, TValue>(this IDictionary<TKey, TValue> dic, IEnumerable<KeyValuePair<TKey, TValue>> collection)
	{
		foreach (var d in collection)
			dic.Add(d.Key, d.Value);
	}

	/// <summary>
	/// 从给定容器确保拿出给定数量的元素，不足按照<paramref name="valueFactory"/>给定的方式补齐
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="data"></param>
	/// <param name="count"></param>
	/// <param name="valueFactory">为null将采用<c>default(T)</c>生成默认元素</param>
	/// <returns></returns>
	public static IEnumerable<T> TakeWhile<T>(this IEnumerable<T> data, int count, Func<T> valueFactory = null)
	{

		int n = 0;
		foreach (var d in data.Take(count))
		{
			n++;
			yield return d;
		}
		for (; n < count; n++)
			yield return valueFactory == null ? default(T) : valueFactory();
	}

	/// <summary>
	/// 将容器大小调整至<paramref name="count"/>
	/// 容器过大则丢弃后面的元素，过小则根据<paramref name="valueFactory"/>提供的规则补齐
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="data"></param>
	/// <param name="count"></param>
	/// <param name="valueFactory">容器大小不足扩容时的值填充，默认为<c>default(T)</c></param>
	/// <returns></returns>
	public static List<T> Resize<T>(this List<T> data, int count, Func<T> valueFactory = null)
	{
		while(data.Count < count)
			data.Add(valueFactory != null ? valueFactory() : default(T));
		if (data.Count > count)
			data.RemoveRange(count, data.Count - count);
		return data;
	}

	/// <summary>Merges two sequences by using the specified predicate function.</summary>
	/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains merged elements of two input sequences.</returns>
	/// <param name="first">The first sequence to merge.</param>
	/// <param name="second">The second sequence to merge.</param>
	/// <param name="resultSelector">A function that specifies how to merge the elements from the two sequences.</param>
	/// <typeparam name="TFirst">The type of the elements of the first input sequence.</typeparam>
	/// <typeparam name="TSecond">The type of the elements of the second input sequence.</typeparam>
	/// <typeparam name="TResult">The type of the elements of the result sequence.</typeparam>
	/// <exception cref="T:System.ArgumentNullException">
	/// <paramref name="first" /> or <paramref name="second" /> is null.</exception>
	public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
	{
		return ZipIterator(first, second, resultSelector);
	}

	/// <summary>Merges two sequences by using the specified predicate function.</summary>
	/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains merged elements of two input sequences.</returns>
	/// <param name="first">The first sequence to merge.</param>
	/// <param name="second">The second sequence to merge.</param>
	/// <typeparam name="TFirst">The type of the elements of the first input sequence.</typeparam>
	/// <typeparam name="TSecond">The type of the elements of the second input sequence.</typeparam>
	/// <exception cref="T:System.ArgumentNullException">
	/// <paramref name="first" /> or <paramref name="second" /> is null.</exception>
	public static IEnumerable<Tuple<TFirst, TSecond>> Zip<TFirst, TSecond>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second)
	{
		return ZipIterator(first, second, (f, s) => Tuple.Create(f, s));
	}

	private static IEnumerable<TResult> ZipIterator<TFirst, TSecond, TResult>(IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
	{
		using (IEnumerator<TFirst> f = first.GetEnumerator())
		using (IEnumerator<TSecond> s = second.GetEnumerator())
		{
			while (f.MoveNext() && s.MoveNext())
			{
				yield return resultSelector(f.Current, s.Current);
			}
		}
	}

#if UNITY_METRO && !UNITY_EDITOR
	public static void ForEach<T>(this List<T> list, Action<T> action)
	{
		foreach (var i in list)
			action(i);
	}
#endif
	#endregion

	#region Stream
	public static byte[] ReadAllBytes(this Stream stream)
	{
		int offset = 0;
		int count = (int)stream.Length;
		var buffer = new byte[count];
		while (count > 0)
		{
			int n = stream.Read(buffer, offset, count);
			if (n == 0)
				throw new EndOfStreamException();
			offset += n;
			count -= n;
		}
		return buffer;
	}
	#endregion

	#region Diagnostics
	/// <summary>
	/// 得到所有公有字段的值，用于调试
	/// </summary>
	/// <param name="obj"></param>
	/// <returns></returns>
	public static string ToStringDebug(this object obj)
	{
		return "{ " + string.Join(", ", (
			from f in obj.GetType().GetRuntimeFields()
			select f.Name + "=" + f.GetValue(obj)).ToArray()) + " }";
	}

	public static string ToStringDebug(this ProtoBuf.IExtensible proto)
	{
		var sb = new StringBuilder();
		using(var writer = new StringWriter(sb))
		{
			WriteTo(proto, writer);
		}
		return sb.ToString();
	}

	private static void WriteTo(ProtoBuf.IExtensible proto, TextWriter writer, int indent = 0)
	{
		var prefix = new string(' ', 4 * indent);
		var tab = "    ";
		if (proto == null)
		{
			writer.Write("<null>");
			return;
		}
		writer.Write(proto.GetType().FullName); writer.WriteLine(" {");
		foreach (var p in proto.GetType().GetRuntimeProperties())
		{
			if (p.GetCustomAttributes(typeof(ProtoBuf.ProtoMemberAttribute), false).Any() == false)
				continue;
			writer.Write(prefix); writer.Write(tab); writer.Write(p.Name); writer.Write(" = ");
			var value = p.GetValue(proto, null);
			if (value is ProtoBuf.IExtensible)
			{
				WriteTo((ProtoBuf.IExtensible)value, writer, indent + 1);
			}
			else if (value is IList)
			{
				writer.Write('['); writer.WriteLine();
				foreach (var line in (value as IList))
				{
					writer.Write(prefix); writer.Write(tab); writer.Write(tab);
					if (line is ProtoBuf.IExtensible)
					{
						WriteTo(line as ProtoBuf.IExtensible, writer, indent + 2);
					}
					else if (line is string)
					{
						writer.Write('"'); writer.Write(line); writer.Write('"');
					}
					else
					{
						writer.Write(line);
					}
					writer.WriteLine();
				}
				writer.Write(prefix); writer.Write(tab); writer.Write(']');
			}
			else if (value is string)
			{
				writer.Write('"'); writer.Write(value); writer.Write('"');
			}
			else
			{
				writer.Write(value);
			}
			writer.WriteLine();
		}
		writer.Write(prefix); writer.Write("}");
	}
	#endregion

	#region XML
	/// <summary>
	/// 获取指定名称的xml属性值
	/// </summary>
	/// <param name="e"></param>
	/// <param name="name"></param>
	/// <returns>失败返回null</returns>
	public static string AttributeValue(this XElement e, XName name)
	{
		if (e != null)
		{
			var a = e.Attribute(name);
			if (a != null)
				return a.Value;
		}
		return null;
	}
	#endregion

	#region String
	public static bool Parse(this string str, bool defaultValue)
	{
		bool ret;
		return bool.TryParse(str, out ret) ? ret : defaultValue;
	}

	public static int Parse(this string str, int defaultValue)
	{
		int ret;
		return int.TryParse(str, out ret) ? ret : defaultValue;
	}
	public static uint Parse(this string str, uint defaultValue)
	{
		uint ret;
		return uint.TryParse(str, out ret) ? ret : defaultValue;
	}

	#endregion

	#region Unity
	/// <summary>
	/// Gets or add a component. Usage example:
	/// BoxCollider boxCollider = transform.GetOrAddComponent&lt;BoxCollider&gt;();
	/// </summary>
	/// <example><code>
	/// BoxCollider boxCollider = transform.GetOrAddComponent&lt;BoxCollider&gt;();
	/// </code></example>
	/// <remarks> ref: http://wiki.unity3d.com/index.php?title=Singleton </remarks>
	public static T GetOrAddComponent<T>(this Component child) where T : Component
	{
		T result = child.GetComponent<T>();
		if (result == null)
		{
			result = child.gameObject.AddComponent<T>();
		}
		return result;
	}

	class ActionToEnumerator : IEnumerable
	{
		private Action action;
		public ActionToEnumerator(Action action) { this.action = action; }

		#region IEnumerable 成员

		public IEnumerator GetEnumerator()
		{
			if (action == null)
				yield break;
			action();
		}

		#endregion
	}

	public static Coroutine StartCoroutine(this MonoBehaviour mb, Action action)
	{
		return mb.StartCoroutine(new ActionToEnumerator(action).GetEnumerator());
	}

	public static IEnumerable<T> GetComponentsDescendant<T>(this GameObject go) where T : Component
	{
		if (go == null)
			return Enumerable.Empty<T>();
		return GetComponentsDescendant<T>(go.transform);
	}

	public static IEnumerable<T> GetComponentsDescendant<T>(this Component c) where T : Component
	{
		if (c == null)
			return Enumerable.Empty<T>();
		return GetComponentsDescendant<T>(c.transform);
	}

	/// <summary>
	/// ref: http://answers.unity3d.com/questions/555101/possible-to-make-gameobjectgetcomponentinchildren.html
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="transform"></param>
	/// <returns></returns>
	public static IEnumerable<T> GetComponentsDescendant<T>(this Transform transform) where T : Component
	{
		if (transform == null)
			yield break;
		foreach(var c in transform.GetComponents<T>())
			yield return c;

		for(int i = 0; i < transform.childCount; i++)
		{
			foreach(var c in GetComponentsDescendant<T>(transform.GetChild(i)))
				yield return c;
		}
	}

	public static IEnumerable<Transform> GetAllChildren(this Transform transform)
	{
		if (transform == null)
			yield break;
		for (var i = 0; i < transform.childCount; i++)
			yield return transform.GetChild(i);
	}

	public static void DestroyAllChildren(this Transform transform)
	{
		if (transform == null)
			return;
		foreach (Transform t in transform)
			GameObject.Destroy(t.gameObject);
	}

	/// <summary>
	/// 得到节点全路径
	/// </summary>
	/// <remarks>
	/// ref: http://answers.unity3d.com/questions/8500/how-can-i-get-the-full-path-to-a-gameobject.html
	/// </remarks>
	/// <param name="current"></param>
	/// <returns></returns>
	public static string GetPath(this Transform current)
	{
		if (current.parent == null)
			return "/" + current.name;
		return GetPath(current.parent) + "/" + current.name;
	}
	/// <summary>
	/// 得到节点全路径
	/// </summary>
	/// <param name="component"></param>
	/// <returns></returns>
	public static string GetPath(this Component component)
	{
		return GetPath(component.transform) + ":" + component.GetType().ToString();
	}
	#endregion

	#region Color
	/// <summary>
	/// 颜色值解析
	/// </summary>
	/// <param name="color"></param>
	/// <param name="value">支持的格式：#RGB, #RRGGBB, #RRGGBBAA, ColorName</param>
	/// <returns></returns>
	public static bool ParseColor(out Color color, string value)
	{
		color = Color.white;
		if (string.IsNullOrEmpty(value))
			return false;
		if (value.StartsWith("#"))
			return Extensions.ParseColorFromRGBA(out color, value.Substring(1));
		else
			return Extensions.ParseColorFromName(out color, value);
	}
	/// <summary>
	/// 颜色值解析
	/// ref: http://www.dreamdu.com/css/css_colors/
	/// </summary>
	/// <param name="color"></param>
	/// <param name="rgba">支持的格式：RGB, RRGGBB, RRGGBBAA</param>
	/// <returns></returns>
	public static bool ParseColorFromRGBA(out Color color, string rgba)
	{
		color = Color.white;
		if (string.IsNullOrEmpty(rgba))
			return false;
		switch(rgba.Length)
		{
			case 3:
				rgba = new string(new char[] { rgba[0], rgba[0], rgba[1], rgba[1], rgba[2], rgba[2], 'F', 'F' });
				goto case 8;
			case 6:
				rgba += "FF";
				goto case 8;
			case 8:
				uint result;
				if (uint.TryParse(rgba, System.Globalization.NumberStyles.AllowHexSpecifier, null, out result))
				{
					color = NGUIMath.HexToColor(result);
					return true;
				}
				break;
			default:
				break;
		}
		return false;
	}

	/// <summary>
	/// 颜色值解析
	/// </summary>
	/// <param name="color"></param>
	/// <param name="colorName">支持的颜色名：black, blue, clear, cyan, gray, green, magenta, red, white, yellow</param>
	/// <returns></returns>
	public static bool ParseColorFromName(out Color color, string colorName)
	{
		switch (colorName)
		{
			case "black": color = Color.black; return true;
			case "blue": color = Color.blue; return true;
			case "clear": color = Color.clear; return true;
			case "cyan": color = Color.cyan; return true;
			case "gray": color = Color.gray; return true;
			case "green": color = Color.green; return true;
			case "grey": color = Color.grey; return true;
			case "magenta": color = Color.magenta; return true;
			case "red": color = Color.red; return true;
			case "white": color = Color.white; return true;
			case "yellow": color = Color.yellow; return true;
			default: color = Color.white; return false;
		}
	}
	#endregion

	#region NGUI
	/// <summary>
	/// 得到鼠标点击/悬浮处的URL内容
	/// </summary>
	/// <returns>失败返回<c>null</c></returns>
	public static string GetUrlTouch(this UILabel label)
	{
		return label != null ? label.GetUrlAtPosition(UICamera.lastHit.point) : null;
	}

	/// <summary>
	/// 测量给定<see cref="UILabel"/>的宽度能容纳的字符串长度
	/// </summary>
	/// <param name="label"></param>
	/// <param name="text">要测量的字符串，为null则采用<c>label.text</c></param>
	/// <param name="startIndex">起始下标</param>
	/// <returns>满足<paramref name="label"/>一行宽度的字符串末尾下标，其他则返回<paramref name="startIndex"/></returns>
	/// <remarks>该函数不会改变<paramref name="label"/>的状态，但会污染<see cref="NGUIText"/>的状态</remarks>
	public static int WrapLine(this UILabel label, string text = null, int startIndex = 0)
	{
		if (label == null)
			return startIndex;
		if (text == null)
			text = label.text;
		if (startIndex < 0 || startIndex >= text.Length)
			return startIndex;

		label.UpdateNGUIText(); // 更新 NGUIText 的状态
		if (NGUIText.rectWidth < 1 || NGUIText.rectHeight < 1 || NGUIText.finalLineHeight < 1f)
			return startIndex;
		NGUIText.Prepare(text); // 准备字体以备测量

		var cur_extent = 0f;
		var prev = 0;
		for (var c = startIndex; c < text.Length; ++c)
		{
			var ch = text[c];
			var w = NGUIText.GetGlyphWidth(ch, prev);
			if (w == 0f)
				continue;
			cur_extent += w + NGUIText.finalSpacingX;
			if (NGUIText.rectWidth < cur_extent)
				return c;
		}

		return text.Length;
	}
	#endregion

	#region Google Protocol Buffers
	/// <summary>
	/// Create a deep clone of the supplied instance; any sub-items are also cloned.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="pb"></param>
	/// <returns></returns>
	public static T DeepClone<T>(this T pb) where T : ProtoBuf.IExtensible
	{
		if (pb == null)
			return default(T);
		return ProtoBuf.Serializer.DeepClone<T>(pb);
	}
	#endregion

	#region Convert DateTime & Unix GMT +8
	static readonly DateTime UnixBase = new DateTime(1970, 1, 1, 0, 0, 0);

	/// <summary>
	/// 将本地时区的DateTime时间转换成Unix时戳
	/// </summary>
	/// <param name="time">本地时间</param>
	/// <returns></returns>
	public static uint ToUnixTime(this DateTime time)
	{
		return (uint)(time - UnixBase).TotalSeconds;
	}

	/// <summary>
	/// 将本地时区的Unix时戳转换成DateTime类型
	/// </summary>
	/// <param name="localGMTTime"></param>
	/// <returns></returns>
	public static DateTime ToDateTime(this uint localGMTTime)
	{
		return UnixBase + TimeSpan.FromSeconds(localGMTTime);
	}
	#endregion
}

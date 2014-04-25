﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Minimap : MonoBehaviour
{
	public UITexture uiMapTexture;
	public UISprite uiFlagMainRole;
	public UISprite uiFlagRole;
	public UISprite[] uiFlagNpc;

	private readonly Dictionary<Entity, UISprite> flags = new Dictionary<Entity, UISprite>();

	private float m_extent = 1024;
	public float Extent
	{
		get { return m_extent; }
		set { m_extent = value; Layout = true; }
	}

	public bool Layout { get; set; }

	private Material material;

	public void Setup()
	{
		uiMapTexture.mainTexture = BattleScene.Instance.MapNav.transform.parent.GetComponentInChildren<MapTexture>().texture;
		uiMapTexture.gameObject.SetActive(uiMapTexture.mainTexture != null);

		if (MainRole.Instance != null)
			MainRole.Instance.entity.PositionChanged += OnMainRolePositionChanged;
		OnMainRolePositionChanged(MainRole.Instance.entity);
	}

	void Start()
	{
		// 对material clone一份，防止运行时的修改影响到源文件
		material = (Material)GameObject.Instantiate(uiMapTexture.material);
		uiMapTexture.material = material;

		Npc.All.ItemAdd += OnNpcAdd;
		Npc.All.ItemRemove += OnNpcRemove;
		Role.All.ItemAdd += OnRoleAdd;
		Role.All.ItemRemove += OnRoleRemove;
		foreach (var i in Npc.All)
			AddFlag(i.Value.GetComponent<Entity>(), GetNpcFlag(i.Value));
		foreach (var i in Role.All)
		{
			if(i.Value.ServerInfo.charid != MainRole.ServerInfo.userdata.charid)
				AddFlag(i.Value.GetComponent<Entity>(), uiFlagRole);
		}
	}

	void OnDestroy()
	{
		if (MainRole.Instance != null)
			MainRole.Instance.entity.PositionChanged -= OnMainRolePositionChanged;

		Npc.All.ItemAdd -= OnNpcAdd;
		Npc.All.ItemRemove -= OnNpcRemove;
		Role.All.ItemAdd -= OnRoleAdd;
		Role.All.ItemRemove -= OnRoleRemove;
		flags.Clear();
	}

	void OnMainRolePositionChanged(Entity sender)
	{
		Layout = true;
	}

	void Update()
	{
		if (Layout && uiMapTexture.gameObject.activeSelf)
		{
			Layout = false;
			var mapNav = BattleScene.Instance.MapNav;
			var size = new Vector2(MapGrid.Width * mapNav.gridXNum, MapGrid.Height * mapNav.gridZNum);
			Extent = Mathf.Min(Extent, uiMapTexture.mainTexture.width, uiMapTexture.mainTexture.height);
			var relativeExtent = new Vector2(Extent / (float)uiMapTexture.mainTexture.width, Extent / (float)uiMapTexture.mainTexture.height);

			var relativePos = new Vector2(MainRole.Instance.entity.Position.x / size.x, MainRole.Instance.entity.Position.z / size.y);

			// 地图位置更新
			material.mainTextureOffset = new Vector2(
				Mathf.Clamp(relativePos.x - 0.5f * relativeExtent.x, 0.0f, 1.0f - relativeExtent.x),
				Mathf.Clamp(relativePos.y - 0.5f * relativeExtent.y, 0.0f, 1.0f - relativeExtent.y));
			material.mainTextureScale = relativeExtent;

			// force update
			if (uiMapTexture.panel != null)
			{
				uiMapTexture.panel.RemoveWidget(uiMapTexture);
				uiMapTexture.panel = null;
			}

			// 主角图标位置更新
			LayoutFlag(MainRole.Instance.entity, uiFlagMainRole);
		}

		// 主角图标显隐
		uiFlagMainRole.gameObject.SetActive(MainRole.Instance != null);
		// 主角图标旋转
		if (MainRole.Instance != null)
			uiFlagMainRole.transform.localRotation = Quaternion.Euler(0, 180, MainRole.Instance.transform.localRotation.eulerAngles.y);

		foreach (var f in flags)
			LayoutFlag(f.Key, f.Value);
	}

	private bool AddFlag(Entity entity, UISprite proto)
	{
		if (entity == null || proto == null)
			return false;
		var sprite = NGUITools.AddChild(uiMapTexture.transform.parent.gameObject, proto.gameObject).GetComponent<UISprite>();
		sprite.name = entity.name;
		flags.Add(entity, sprite);
		return true;
	}

	private bool RemoveFlag(Entity entity)
	{
		if (entity == null)
			return false;
		UISprite sprite;
		if (flags.TryGetValue(entity, out sprite) == false)
			return false;
		flags.Remove(entity);
		GameObject.Destroy(sprite.gameObject);
		return true;
	}

	private void LayoutFlag(Entity entity, UISprite flag)
	{
		var mapNav = BattleScene.Instance.MapNav;
		var size = new Vector2(MapGrid.Width * mapNav.gridXNum, MapGrid.Height * mapNav.gridZNum);
		var relativeExtent = new Vector2(Extent / (float)uiMapTexture.mainTexture.width, Extent / (float)uiMapTexture.mainTexture.height);

		var relativePos = new Vector2(entity.Position.x / size.x, entity.Position.z / size.y);
		var p = relativePos - material.mainTextureOffset;
		p.x /= relativeExtent.x;
		p.y /= relativeExtent.y;
		flag.gameObject.SetActive((p - new Vector2(0.5f, 0.5f)).magnitude < 0.5f);
		if (flag.gameObject.activeSelf)
		{
			flag.leftAnchor.Set(p.x, -flag.width * 0.5f);
			flag.rightAnchor.Set(p.x, flag.width * 0.5f);
			flag.topAnchor.Set(p.y, flag.height * 0.5f);
			flag.bottomAnchor.Set(p.y, -flag.height * 0.5f);
			flag.UpdateAnchors();
		}
	}

	UISprite GetNpcFlag(Npc npc)
	{
		var index = (int)npc.TableInfo.BaseType;
		if (index >= 0 && index < uiFlagNpc.Length)
			return uiFlagNpc[index];
		return null;
	}

	private void OnNpcAdd(object sender, GX.EventArgs<KeyValuePair<ulong, Npc>> args)
	{
		AddFlag(args.Data.Value.GetComponent<Entity>(), GetNpcFlag(args.Data.Value));
	}

	private void OnNpcRemove(object sender, GX.EventArgs<KeyValuePair<ulong, Npc>> args)
	{
		try
		{
			RemoveFlag(args.Data.Value.GetComponent<Entity>());
		}
		catch (MissingReferenceException) { }
	}

	private void OnRoleAdd(object sender, GX.EventArgs<KeyValuePair<ulong, Role>> args)
	{
		if (args.Data.Value.ServerInfo.charid != MainRole.ServerInfo.userdata.charid)
			AddFlag(args.Data.Value.GetComponent<Entity>(), uiFlagRole);
	}

	private void OnRoleRemove(object sender, GX.EventArgs<KeyValuePair<ulong, Role>> args)
	{
		try
		{
			RemoveFlag(args.Data.Value.GetComponent<Entity>());
		}
		catch (MissingReferenceException) { }
	}
}

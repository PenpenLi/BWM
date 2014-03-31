﻿using UnityEngine;
using System.Collections;
using System.Linq;

public class SkillInfo : MonoBehaviour
{
	public UIButton uiClose;
	public UIButton[] uiSkillFireThumbs;
	public UIButton uiSkillFireOK;
	private SkillInfoItem[] items;
	private SkillInfoItem selected;
	private int thumbIndex = -1;

	public UILabel infoName;
	public UILabel infoRequire;
	public UILabel infoCD;
	public UILabel infoDesc;
	public UIButton infoUpgrade;

	void Start()
	{
		UIEventListener.Get(uiClose.gameObject).onClick = go => this.gameObject.SetActive(false);

		// 技能格子初始化
		var grid = this.transform.FindChild("SkillBar");
		items = new SkillInfoItem[grid.childCount];
		for (var i = 0; i < grid.childCount; i++)
		{
			var view = grid.GetChild(i).GetComponent<SkillInfoItem>();
			items[i] = view;
			view.gameObject.name = i.ToString("D2");

			// 格子点击
			UIEventListener.Get(view.uiIcon.gameObject).onClick = go => PresentInfo(view);
		}

		// 技能释放按钮
		for (var i = 0; i < uiSkillFireThumbs.Length; i++)
		{
			var button = uiSkillFireThumbs[i];
			var index = i;
			UIEventListener.Get(button.gameObject).onClick = go =>
			{
				if(selected == null || selected.Skill.Value == null)
					return;
				button.normalSprite = selected.Skill.Value.icon;
				thumbIndex = index;
			};
		}
		UIEventListener.Get(uiSkillFireOK.gameObject).onClick = go =>
		{
			if (selected == null || selected.Skill.Value == null || thumbIndex < 0)
				return;
			Config.UserData.Instance.skillbar[thumbIndex] = selected.Skill.Value.id;
			Config.UserData.Instance.FirePropertyChanged("skillbar");
			thumbIndex = -1;
			PresentFireThumbs(this.uiSkillFireThumbs);
		};
		PresentFireThumbs(this.uiSkillFireThumbs);

		// 更新事件
		SkillManager.Instance.SkillChanged += PresentIcons;
		PresentIcons(SkillManager.Instance);

		// 技能 升级/学习 按钮
		UIEventListener.Get(infoUpgrade.gameObject).onClick = OnSkillUpgrade;
	}

	void OnDestroy()
	{
		SkillManager.Instance.SkillChanged -= PresentIcons;
	}


	void OnEnable()
	{
		NGUITools.BringForward(this.gameObject);
		PresentIcons(SkillManager.Instance);
	}

	/// <summary>
	/// 显示最上面的技能按钮
	/// </summary>
	/// <param name="manager"></param>
	private void PresentIcons(SkillManager manager)
	{
		if (this.gameObject.activeSelf == false || items == null)
			return;
		// 为每个按钮关联对应的技能
		foreach (var i in items.Zip(manager.OrderBy(i => i.Key)))
			i.Item1.Skill = i.Item2;

		// 默认选中第一个学会的技能
		if (selected == null)
		{
			foreach (var i in items)
			{
				if (i.Skill.Value == null)
					continue;
				var click = UIEventListener.Get(i.uiIcon.gameObject).onClick;
				if(click != null)
					click(i.uiIcon.gameObject);
				i.uiIcon.GetComponent<UIToggle>().value = true;
				selected = i;
				break;
			}
		}
	}

	/// <summary>
	/// 显示技能详细信息
	/// </summary>
	/// <param name="view"></param>
	private void PresentInfo(SkillInfoItem view)
	{
		selected = view;
		// 重置施法按钮为默认状态
		PresentFireThumbs(this.uiSkillFireThumbs);

		// 基本技能信息显示
		var s = view.Skill.Value ?? table.TableSkill.First(view.Skill.Key);
		infoName.text = string.Format("[e28c00]{0}  {1}级[-]", s.name, s.level);
		infoRequire.text = string.Format("[e28c00]消耗真气: [-]{0}点  距离{1}码", s.requirePoint, s.radius);
		infoCD.text = string.Format("[e28c00]冷却时间: [-]{0}秒", s.cd);
		infoDesc.text = s.desc;

		// 升级/学习 按钮
		infoUpgrade.isEnabled = view.Skill.Value == null || view.Skill.Value.level < view.Skill.Value.levelMax;
		if (infoUpgrade.isEnabled)
			infoUpgrade.GetComponentInChildren<UILabel>().text = view.Skill.Value != null ? "升级" : "学习";
	}

	/// <summary>
	/// 技能施法按钮显示状态和<see cref="Config.UserData.Instance"/>中的配置一致
	/// </summary>
	public static void PresentFireThumbs(UIButton[] skillButtons)
	{
		for (var i = 0; i < skillButtons.Length; i++)
		{
			var skill = SkillManager.Instance.GetSkill(Config.UserData.Instance.skillbar[i]);
			var button = skillButtons[i];
			button.GetComponent<UISprite>().spriteName =
				button.disabledSprite =
				button.hoverSprite =
				button.pressedSprite =
				button.normalSprite =
				skill != null ? skill.icon : string.Empty;
			//Debug.Log(string.Format("PresentFireThumbs {0}: {1}", i, button.normalSprite));
		}
	}

	/// <summary>
	/// 升级/学习 技能
	/// </summary>
	/// <param name="go"></param>
	private void OnSkillUpgrade(GameObject go)
	{
		if (selected.Skill.Value == null)
		{
			Debug.Log("TODO: study skill " + selected.Skill.Key);
		}
		else
		{
			Debug.Log("TODO: upgrade skill " + selected.Skill.Key);
		}
	}
}

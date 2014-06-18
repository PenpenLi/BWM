﻿using UnityEngine;
using System.Collections;

public class SelectTargetMonster : MonoBehaviour
{
	public UILabel uiLevel;
	public UILabel nameLabel;
	public UISlider uiHp;
	public UILabel uiHpText;

	internal void OnSelect(Npc target)
	{
		nameLabel.text = target.TableInfo.name;
		uiLevel.text = target.TableInfo.level.ToString();
	}

	internal void OnUpdate(Npc target)
	{
		uiHp.value = target.ServerInfo.hp / (float)target.ServerInfo.maxhp;
		uiHpText.text = target.ServerInfo.hp + "/" + target.ServerInfo.maxhp;
	}
}

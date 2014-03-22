﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Skill))]
public class SkillDelayToTarget : SkillBase {

	public bool sendTargetEvent = false;
	public float delay = 1.0f;

	// Use this for initialization
	override public void StartSkill () {
		if(delay > 0.0f)
		{
			iTween.ValueTo(gameObject, iTween.Hash("from",delay,"to",0.0f,"time",delay,"onupdate", "onUpdate", "oncomplete","StartTargetEvent"));
		}
		else
		{
			StartTargetEvent();
		}		
	}

	void onUpdate(float delay) {}

	void StartTargetEvent()
	{
		if(sendTargetEvent)
			gameObject.SendMessage("ApplyTargetEvent");
		Destroy(this);
	}
}

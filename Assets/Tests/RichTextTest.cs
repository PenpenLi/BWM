﻿using UnityEngine;
using System.Collections;

public class RichTextTest : MonoBehaviour
{
	public RichText uiRichText;
	public UIButton testWidget;

	void Start()
	{
		uiRichText.AddLabel("hello world");
		uiRichText.AddWidget(testWidget.gameObject);
	}

	void OnGUI()
	{
	}
}

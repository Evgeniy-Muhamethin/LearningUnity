using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MainCode : MonoBehaviour
{
	[SerializeField]
	private TMP_Text _text;

	private void Start()
	{
		@TEXT("First message", Color.red, 50, _text);
	}

	private void @TEXT(string textPrint, Color color,
		float size, TMP_Text text)
	{
		text.text = textPrint;
		text.color = color;
		text.fontSize = size;
		text.alignment = TextAlignmentOptions.Flush;
		text.alignment = TextAlignmentOptions.Midline;
		text.alignment = TextAlignmentOptions.Center;
	}
}

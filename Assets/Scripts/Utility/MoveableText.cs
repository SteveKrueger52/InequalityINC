﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// Moves text across screen. 
/// </summary>
public class MoveableText : MonoBehaviour
{
	private TextMeshProUGUI text;

	/// <summary>
	/// Whether or not to skip the delay for text being written.
	/// </summary>
	private bool skip;

	/// <summary>
	/// The amount of delay between letters being typed. 
	/// </summary>
	private float letterDelay = 0.005f;

	/// <summary>
	/// Gets or sets the letter delay.
	/// </summary>
	/// <value>The letter delay.</value>
	public float LetterDelay
	{
		get { return letterDelay; }
		set { letterDelay = value; }
	}

	// Use this for initialization
	void Awake()
	{
		text = GetComponent<TextMeshProUGUI>();
	}


	/// <summary>
	/// Clears the text. 
	/// </summary>
	public void ClearText()
	{
		text.text = "";
	}


	/// <summary>
	/// Skips text on spacebar.
	/// </summary>
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			skip = true;
		}
	}


	/// <summary>
	/// Types text across the screen. 
	/// </summary>
	/// <param name="message">The message to be displayed</param>
	public IEnumerator TypeText(string message)
	{
		skip = false;
		ClearText();
		string current = "";
		char[] m = message.ToCharArray();
		for (int i = 0; i < message.Length; i++)
		{
			if (skip)
			{
				text.text = message;
				skip = false;
				break;
			}
			current += m[i];
			text.text = current;
			text.text += "<color=#00000000>";
			for (int j = i + 1; j < message.Length; j++)
			{
				text.text += m[j];
			}
			text.text += "</color>";
			yield return new WaitForSecondsRealtime(letterDelay);
		}
	}
}

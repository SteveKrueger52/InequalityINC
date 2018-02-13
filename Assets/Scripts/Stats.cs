﻿using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// All of the stats for our game. 
/// </summary>
public class Stats
{

	/// <summary>
	/// The current time in minutes. 
	/// </summary>
	public static int currentTime;

	/// <summary>
	/// The relationship points for each character. 
	/// </summary>
	public static Dictionary<UIManager.Character, int> relationshipPoints = new Dictionary<UIManager.Character, int>();

	/// <summary>
	/// Whether or not the player has gotten information from the given character on the given day
	/// The list of bools is the various pieces of information the player potentially has on the character. 
	/// </summary>
	public static Dictionary<UIManager.Character, List<bool>> hasInfoOn = new Dictionary<UIManager.Character, List<bool>>();


	/// <summary>
	/// Resets all in-game stats. 
	/// </summary>
	public void ResetAll()
	{
		ResetDay();
		foreach (UIManager.Character c in Enum.GetValues(typeof(UIManager.Character)))
		{
			relationshipPoints[c] = 0;
		}
		foreach (UIManager.Character c in Enum.GetValues(typeof(UIManager.Character)))
		{
			hasInfoOn[c] = new List<bool>(10);
			for (int i = 0; i < hasInfoOn[c].Count; ++i)
			{
				hasInfoOn[c][i] = false;
			}
		}
	}


	/// <summary>
	/// Resets all stats of the current day. 
	/// </summary>
	public void ResetDay()
	{
		currentTime = 9 * 60;
	}
}

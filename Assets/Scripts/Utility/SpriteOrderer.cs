﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Sets the sprite render order so that sprites that are
/// higher up are layered below sprites that are below. 
/// </summary>
public class SpriteOrderer : MonoBehaviour {

	/// <summary>
	/// Offset for sprite sort order if it needs to be on top or below only sometimes. 
	/// </summary>
	public int offset = 0;

	/// <summary>
	/// The sprite renderer for this gameobject
	/// </summary>
	private SpriteRenderer s;

	void Awake() {
		s = GetComponent<SpriteRenderer>();
	}

	void Update() {
		s.sortingOrder = Mathf.RoundToInt(transform.position.y * -10) + offset;
	}
}

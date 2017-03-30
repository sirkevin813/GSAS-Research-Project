﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rpiLogoBehavior : MonoBehaviour {
	SpriteRenderer sr;
	bool fade_in = false;

	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
		sr.color = new Color (sr.color.r, sr.color.g, sr.color.b, 0f);
		StartCoroutine (Show ());
	}
	
	// Update is called once per frame
	void Update () {
		if (fade_in)
			sr.color = new Color (sr.color.r, sr.color.g, sr.color.b, sr.color.a+.03f);
	}

	IEnumerator Show(){
		yield return new WaitForSeconds(3f);
		fade_in = true;
	}
}

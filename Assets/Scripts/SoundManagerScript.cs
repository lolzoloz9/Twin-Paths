﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

	public static AudioClip rogueDashSound, rogueWalkSound;
	static AudioSource audioSrc;

	// Use this for initialization
	void Start () {
		rogueDashSound = Resources.Load<AudioClip> ("Rogue Dash V3");
		rogueWalkSound = Resources.Load<AudioClip> ("Rogue Footstep");

		audioSrc = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void PlaySound (string clip) {
		switch (clip) {
		case "Rogue Dash V3":
			Debug.Log ("Playing Dash");
			audioSrc.PlayOneShot (rogueDashSound);
			break;
		case "Rogue Footstep":
			audioSrc.PlayOneShot (rogueWalkSound);
			break;
		}
	}
}

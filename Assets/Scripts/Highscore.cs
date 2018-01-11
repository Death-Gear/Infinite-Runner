using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highscore : MonoBehaviour {

	// Use this for initialization
	private int sound;

	void Start () {
		sound = 0;
	}

	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("high") < Score.score) {

			PlayerPrefs.SetInt ("high", Score.score);
		}
		GetComponent<TextMesh> ().text = "HIGHSCORE\n" + PlayerPrefs.GetInt ("high");
		if (Time.timeScale == 0 && sound == 0) {
			GetComponent<AudioSource> ().Play();
			sound = 1;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	public static int score;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		score = 0;
		GetComponent<TextMesh>().text = "SCORE: " + score;
		GameObject.Find ("Scoreboard").transform.position = new Vector3 (-21.0f, 0.0f, 0.0f);
		GameObject.Find ("RightButton").transform.position = new Vector3 (7f, -2.5f, 0.0f);
		GameObject.Find ("UpButton").transform.position = new Vector3 (-6.5f, -2.5f, 0.0f);
		GameObject.Find ("LeftButton").transform.position = new Vector3 (4.7f, -2.5f, 0.0f);
	}

	// Update is called once per frame
	void Update () {
		GetComponent<TextMesh>().text = "SCORE: " + score;
		GameObject.Find ("Scoreover").GetComponent<TextMesh> ().text = "SCORE\n" + score;

		if (Time.timeScale == 0) {
			GameObject.Find ("Scoreboard").transform.position = new Vector3 (0.0f, 0.0f, 0.0f);
			GameObject.Find ("RightButton").transform.position = new Vector3 (-21.0f, -2.5f, 0.0f);
			GameObject.Find ("UpButton").transform.position = new Vector3 (-21.0f, -2.5f, 0.0f);
			GameObject.Find ("LeftButton").transform.position = new Vector3 (-21.0f, -2.5f, 0.0f);
			GetComponent<AudioSource> ().Stop();
		}
	}
}

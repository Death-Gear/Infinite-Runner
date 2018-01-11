using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Buttons.Quit) {
			transform.localPosition = new Vector3 (0.18f, 0.8f, -0.5f);
			GameObject.Find ("Play").transform.position = new Vector3 (-21.0f, 0.0f, -0.5f);
			GameObject.Find ("Help").transform.position = new Vector3 (-21.0f, -1.02f, -0.5f);
			GameObject.Find ("Exit").transform.position = new Vector3 (-21.0f, -1.02f, -0.5f);
		} else {
			transform.localPosition = new Vector3 (-21.0f, 0.8f, -0.5f);
		}
	}
}

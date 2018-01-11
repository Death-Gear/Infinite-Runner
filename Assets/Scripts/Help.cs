using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Buttons.Help) {
			transform.localPosition = new Vector3 (0.0f, 1.0f, -0.5f);
			GameObject.Find ("Play").transform.position = new Vector3 (-21.0f, 0.0f, -0.5f);
			GameObject.Find ("Help").transform.position = new Vector3 (-21.0f, -1.02f, -0.5f);
			GameObject.Find ("Exit").transform.position = new Vector3 (-21.0f, -1.02f, -0.5f);
		} else if(!Buttons.Quit){
			transform.localPosition = new Vector3 (-21.0f, 1.0f, -0.5f);
			GameObject.Find ("Play").transform.position = new Vector3 (0.0f, 0.0f, -0.5f);
			GameObject.Find ("Help").transform.position = new Vector3 (4.0f, -1.02f, -0.5f);
			GameObject.Find ("Exit").transform.position = new Vector3 (-4.0f, -1.02f, -0.5f);
		}
	}
}

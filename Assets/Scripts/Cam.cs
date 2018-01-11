using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Camera>().aspect = 1024f/600f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

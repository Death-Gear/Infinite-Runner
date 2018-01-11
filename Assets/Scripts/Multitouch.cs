using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multitouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Touch[] touches = Input.touches;
		for (int i = 0; i < touches.Length; ++i) {
			Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch (i).position);
			if (Input.GetTouch (i).phase == TouchPhase.Began) {
				if (GetComponent<Collider2D> ().OverlapPoint (wp) && GetComponent<Collider2D> ().name == "UpButton") {
					print (GetComponent<Collider2D> ().name);
						Buttons.Jump = true;
					transform.localScale = new Vector3 (0.25f, 0.25f, 1.0f);
				} else if (GetComponent<Collider2D> ().OverlapPoint (wp) && GetComponent<Collider2D> ().name == "RightButton") {
					transform.localScale = new Vector3 (0.25f, 0.25f, 1.0f);
					if (Buttons.Right == false)
						Buttons.Flip = true;
					else
						Buttons.Flip = false;
					Buttons.Right = true;
				} else if (GetComponent<Collider2D> ().OverlapPoint (wp) && GetComponent<Collider2D> ().name == "LeftButton") {
					transform.localScale = new Vector3 (0.25f, 0.25f, 1.0f);
					if (Buttons.Right == true)
						Buttons.Flip = true;
					else
						Buttons.Flip = false;
					Buttons.Right = false;
				}
			} else if (Input.GetTouch (i).phase == TouchPhase.Ended) {
				if (GetComponent<Collider2D> ().OverlapPoint (wp) && GetComponent<Collider2D> ().name == "UpButton") {
					print (GetComponent<Collider2D> ().name);
					//Buttons.Jump = false;
					transform.localScale = new Vector3 (0.2f, 0.2f, 1.0f);
				} else if (GetComponent<Collider2D> ().OverlapPoint (wp) && (GetComponent<Collider2D> ().name == "RightButton" || GetComponent<Collider2D> ().name == "LeftButton")) {
					Buttons.Run = false;
					if (GetComponent<Collider2D> ().name == "LeftButton")
						Buttons.Run_left = false;
					else
						Buttons.Run_right = false;
					transform.localScale = new Vector3 (0.2f, 0.2f, 1.0f);
				}
			} else if (Input.GetTouch (i).phase == TouchPhase.Stationary) {
				if (GetComponent<Collider2D> ().OverlapPoint (wp) && GetComponent<Collider2D> ().name == "LeftButton") {
					Buttons.Run = true;
					Buttons.Run_left = true;
				} else if (GetComponent<Collider2D> ().OverlapPoint (wp) && GetComponent<Collider2D> ().name == "RightButton") {
					Buttons.Run = true;
					Buttons.Run_right = true;
				}
			}
		}
	}
}

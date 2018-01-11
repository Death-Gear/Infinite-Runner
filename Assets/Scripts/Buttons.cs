using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

	// Use this for initialization

	public static bool Right;
	public static bool Flip,Run,Jump,Run_left,Run_right;
	public static bool Help, Quit, f;
	void Start () {
		Right = true;
		Flip = false;
		Run = false;
		Jump = false;
		Run_left = false;
		Run_right = false;
		Help = false;
		Quit = false;
		f = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown ()
	{
		if (transform.name == "Play") {
			transform.localScale = new Vector3 (0.4f, 0.4f, 1.0f);
			Application.LoadLevel ("Level Select");
		} else if (transform.name == "Home") {
			transform.localScale = new Vector3 (0.6f, 0.6f, 1.0f);
			Application.LoadLevel ("Menu");
		} else if (transform.name == "Replay") {
			transform.localScale = new Vector3 (0.6f, 0.6f, 1.0f);
			//yield return new WaitForSeconds (1);
			Application.LoadLevel ("Level Select");
		} else if (transform.name == "Exit") {
			transform.localScale = new Vector3 (0.4f, 0.4f, 1.0f);
			Quit = true;
			Application.Quit ();
		} else if (transform.name == "Help") {
			transform.localScale = new Vector3 (0.4f, 0.4f, 1.0f);
			Help = true;
		} else if (transform.name == "Menu") {
			transform.localScale = new Vector3 (0.5f, 0.5f, 1.0f);
			Help = false;
		} else if (transform.name == "Yes") {
			transform.localScale = new Vector3 (0.7f, 0.7f, 1.0f);
			Application.Quit ();
			print ("Quit");
		} else if (transform.name == "No") {
			transform.localScale = new Vector3 (0.7f, 0.7f, 1.0f);
			Quit = false;
		} else if (transform.name == "Lava Cave") {
			print ("lava");
			if (f == true) {
				Application.LoadLevel ("Gameplay");
			}
			f = true;
		} else if (transform.name == "Graveyard") {
			print ("graveyard");
			if (f == true) {
				Application.LoadLevel ("Gameplay1");
			}
			f = true;
		} else if (transform.name == "Frost Park") {
			print ("Frost Park");
			if (f == true) {
				Application.LoadLevel ("Gameplay2");
			}
			f = true;

		}
	}

	void OnMouseUp ()
	{
		if (transform.name == "Home" || transform.name == "Replay") {
			transform.localScale = new Vector3 (0.55f, 0.55f, 1.0f);
		} else if (transform.name == "Play" || transform.name == "Exit" || transform.name == "Help") {
			transform.localScale = new Vector3 (0.3f, 0.3f, 1.0f);
		} else if (transform.name == "Menu") {
			transform.localScale = new Vector3 (0.4f, 0.4f, 1.0f);
		} else if (transform.name == "Yes") {
			transform.localScale = new Vector3 (0.6f, 0.6f, 1.0f);
		} else if (transform.name == "No") {
			transform.localScale = new Vector3 (0.6f, 0.6f, 1.0f);
		}
	}
}

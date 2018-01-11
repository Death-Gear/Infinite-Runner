using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background2Move : MonoBehaviour {


	private float Background_speed;
	// Use this for initialization
	void Start () {
		Background_speed = 4.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Buttons.Run_right)
			transform.Translate(Vector3.left * Background_speed * Time.deltaTime);
		else if (Buttons.Run_left)
			transform.Translate(Vector3.right * Background_speed * Time.deltaTime);


		if (transform.localPosition.x <= -17.07f)
			transform.localPosition += new Vector3(2 * (17.06f - 0.0f), 0, 0);
		if (transform.localPosition.x > 17.07f)
			transform.localPosition -= new Vector3(2 * (17.06f - 0.0f), 0, 0);
	}
}

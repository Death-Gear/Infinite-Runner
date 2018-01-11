using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background1_move : MonoBehaviour {

	// Use this for initialization

	private float Background_speed;

	void Start () {
		Background_speed = 4.0f;
	}

	// Update is called once per frame
	void Update () {
		if (Buttons.Run_right)
			transform.Translate(Vector3.left * Background_speed * Time.deltaTime);
		else if (Buttons.Run_left)
			transform.Translate(Vector3.right * Background_speed * Time.deltaTime);


		if (transform.localPosition.x <= -17.06f)
			transform.localPosition += new Vector3(2 * (17.00f - 0), 0, 0);
		if (transform.localPosition.x > 17.06f)
			transform.localPosition -= new Vector3(2 * (17.00f - 0), 0, 0);
	}
}

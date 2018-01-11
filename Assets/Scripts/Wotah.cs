using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wotah : MonoBehaviour {

	private float ground_speed;
	// Use this for initialization
	void Start () {
		ground_speed = 4.0f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * ground_speed * Time.deltaTime);

		if (Buttons.Run_right)
			transform.Translate(Vector3.left * ground_speed * Time.deltaTime);
		/*else if (Buttons.Run_left)
			transform.Translate(Vector3.right * ground_speed * Time.deltaTime);*/

		if (transform.localPosition.x <= -16.87f)
			transform.localPosition += new Vector3(2 * (18.16f - 0.6522692f), 0, 0);

		if (Time.deltaTime == 0)
			Destroy (gameObject);
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundmove : MonoBehaviour {
	// Use this for initialization

	private float ground_speed;
	public static bool colliding;

	void Start () {
		ground_speed = 5.0f;
	}

	// Update is called once per frame
	void Update () {
		if (Buttons.Run_right)
			transform.Translate(Vector3.left * ground_speed * Time.deltaTime);
		else if (Buttons.Run_left)
			transform.Translate(Vector3.right * ground_speed * Time.deltaTime);


		if (transform.localPosition.x <= -17.053f)
			transform.localPosition += new Vector3(2 * (17.36f - 0.24f), 0, 0);
		if (transform.localPosition.x > 17.053f)
			transform.localPosition -= new Vector3(2 * (17.36f - 0.24f), 0, 0);
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.name == "Player") {
			colliding = true;
			Player.isGrounded = true;
		}

	}
	void OnCollisionExit(Collision collision)
	{
		if (collision.collider.name == "Player") {
			colliding = false;
			Player.isGrounded = false;
		}
	}

	void OnCollisionStay(Collision collision){
		if (collision.collider.name == "Player") {
			colliding = true;
			Player.isGrounded = true;
		}
	}
}

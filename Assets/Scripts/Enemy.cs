using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	private float zombie_speed;
	public float flag, flag1, position_x, position_y;
	public GameObject Zombie;
	// Use this for initialization
	void Start () {
		zombie_speed = 4.0f;
		flag = 0;
		flag1 = 0;
		if (transform.localScale.x >= 0) {
			flip ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Buttons.Run_right) {
			transform.Translate (Vector3.left * zombie_speed * Time.deltaTime);
		} else if (Buttons.Run_left) {
			transform.Translate(Vector3.right * zombie_speed * Time.deltaTime);
		}

		if (transform.position.x <= -9 && flag==0) 
		{

			Enemy_Gen();   //generating new bars
			flag=1;
		}


		if (transform.position.x <= -9 && flag1==0) 
		{
			flag1=1;
		}



		if (transform.localPosition.x <= -9.5f) {
			flip ();
			Destroy (gameObject);
		}
		if (Time.timeScale == 0) {
			Destroy (gameObject);
		}	

	}

	private void flip(){
		Vector3 theScale = transform.localScale;

		theScale.x *= -1;

		transform.localScale = theScale;
	}

	void Enemy_Gen() //new bar clone
	{
		position_y = transform.localPosition.y;
		position_x = Random.Range ( 7.0f, 11.0f);
		zombie_speed = Random.Range ( 3.0f, 5.0f);
		Instantiate (Zombie, new Vector3 (position_x, position_y, 0), Quaternion.Euler (new Vector3 (0, 0, 0)));
	}

	void OnCollisionEnter(Collision collision){
		if (collision.collider.name == "Player") {
			Destroy (gameObject);
			Time.timeScale = 0;
		}
	}
}

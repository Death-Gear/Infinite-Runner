using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	// Use this for initialization
	public GameObject bird;
	private float bird_speed;
	public float flag, flag1, position_x, position_y;
	public bool f;
	void Start () {
		bird_speed = 2.0f;
		flag = 0;
		flag1 = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate (Vector3.left * bird_speed * Time.deltaTime);

		if (Buttons.Right) {
			transform.Translate (Vector3.left * 2*bird_speed * Time.deltaTime);

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
			Destroy (gameObject);
		}
			
	}

	void Enemy_Gen() //new bar clone
	{
		position_y = Random.Range ( 1.8f, 3.5f);
		position_x = Random.Range ( 7.0f, 11.0f);
		bird_speed = Random.Range ( 3.0f, 4.0f);
		Instantiate (bird, new Vector3 (position_x, position_y, -0.8f), Quaternion.Euler (new Vector3 (0, 0, 0)));
	}

	void OnTriggerEnter(Collider collision){
		if (collision.gameObject.name == "Player") {
			Destroy (gameObject);
			Time.timeScale = 0;
		}
	}
}

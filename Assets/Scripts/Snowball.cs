using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball : MonoBehaviour {

	private float Tile_speed,flag,flag1,position_x,position_y;
	public static bool colliding;
	private int indx;
	public GameObject tile;
	// Use this for initialization
	void Start () {
		Tile_speed = 4.0f;
		flag = 0;
		flag1 = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Buttons.Run_right) 
			transform.Translate(Vector3.left * Tile_speed * Time.deltaTime);
		else if(Buttons.Run_left)
			transform.Translate(Vector3.right * Tile_speed * Time.deltaTime);

		if ((transform.position.y <= -3 || transform.position.x <= -3) && flag==0) 
		{

			tile_Gen ();   //generating new bars
			flag=1;
		}


		if ((transform.position.y <= -3 || transform.position.x <= -3) && flag1==0) 
		{
			flag1=1;
		}



		if (transform.localPosition.y <= -9.5f) {
			Destroy (gameObject);
		}
	}

	void tile_Gen() //new bar clone
	{
		//position_y = Random.Range (2.0f, 5.0f);
		position_y = 7.0f;
		position_x = Random.Range (0.0f, 7.0f);
		indx = Random.Range (0,2);
		Instantiate (tile, new Vector3 (position_x, position_y, -0.8f), Quaternion.Euler (new Vector3 (0, 0, 0)));
	}

	void OnTriggerEnter(Collider collision){
		if (collision.gameObject.name == "Player") {
			Destroy (gameObject);
			Time.timeScale = 0;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone1Control : MonoBehaviour {


	private float Stone_speed,Rotate_speed;
	public static float Down_speed, Up_speed;
	private int st;
	private bool exit;
	public GameObject[] stones;
	public float flag,flag1,position_x,position_y;
	public int indx;
	// Use this for initialization
	void Start () {
		exit = false;
		Down_speed = 0.6f;
		Up_speed = 0.4f;
		Stone_speed = 4.0f;
		Rotate_speed = 10.0f;
		st = Random.Range (0, 2);
		flag = 0;
		flag1 = 0;
		position_x = 0;
	}

	// Update is called once per frame
	void Update () {
		if(Buttons.Run_right) 
			transform.Translate(Vector3.left * Stone_speed * Time.deltaTime, Space.World);
		else if(Buttons.Run_left)
			transform.Translate(Vector3.right * Stone_speed * Time.deltaTime, Space.World);

		if (transform.position.x <= 4 && flag==0) 
		{

			Stone_Gen();
			flag=1;
		}


		if (transform.position.x <= 4 && flag1==0) 
		{
			flag1=1;
		}


		if (transform.position.x <= -30)
			Destroy (gameObject);
		if (Time.timeScale == 0)
			Destroy (gameObject);
		if (exit)
			transform.Translate (Vector3.up * Up_speed * Time.deltaTime, Space.Self);

		if (transform.position.y >= position_y)
			exit = false;

		//StoneRotate ();
	}

	void OnCollisionEnter(Collision collision)
	{
		exit = false;
		Player.isGrounded = true;
	}
	void OnCollisionExit(Collision collision)
	{
		//yield return new WaitForSeconds (0.25f);
		exit = true;
		Player.isGrounded = false;
	}

	void OnCollisionStay(Collision collision){
		exit = false;
		Player.isGrounded = true;
		//transform.Translate (Vector3.down * Down_speed * Time.deltaTime, Space.World);
	}


	/*void StoneRotate() {
		if (transform.rotation.z < 0.18f && st == 0) {
			transform.Rotate (Vector3.forward * Rotate_speed * Time.deltaTime);
			if (transform.rotation.z >= 0.18f) {
				st = 1;
			}
		} else {
			transform.Rotate (Vector3.back * Rotate_speed * Time.deltaTime);
			if (transform.rotation.z <= -0.18f) {
				st = 0;
			}
		}			
	}*/

	void Stone_Gen(){
		indx = Random.Range (0,3);
		position_y = Random.Range (-1.5f, 1.7f);
		position_x = Random.Range (10.0f, 11.0f);
		Instantiate (stones[indx], new Vector3 (position_x, position_y, -0.5f), Quaternion.identity);
	}
}


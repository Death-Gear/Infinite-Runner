using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemsControl : MonoBehaviour {

	public GameObject[] Gems;
	public float  speed_gems,flag,flag1,position_x,position_y;
	public int indx;

	// Use this for initialization
	void Start () {
		speed_gems = 4.0f;
		flag = 0;
		flag1 = 0;
		//position_x = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Buttons.Run_right) 
			transform.Translate(Vector3.left * speed_gems * Time.deltaTime);
		else if(Buttons.Run_left)
			transform.Translate(Vector3.right * speed_gems * Time.deltaTime);


		if (transform.position.x <= 5 && flag==0) 
		{

			Gems_Gen();   //generating new bars
			flag=1;
		}


		if (transform.position.x <= 5 && flag1==0) 
		{
			flag1=1;
		}


		if (transform.position.x <= -11)
			Destroy (gameObject);

		if (Time.timeScale == 0)
			Destroy (gameObject);
	}

	void Gems_Gen() //new bar clone
	{
		position_y = Random.Range (2.0f, 5.0f);
		position_x = Random.Range (7.0f, 15.0f);
		indx = Random.Range (0,2);
		Instantiate (Gems[indx], new Vector3 (position_x, position_y, -0.2f), Quaternion.Euler (new Vector3 (0, 0, 0)));
	}

	IEnumerator OnTriggerEnter (Collider collider){
		/*if(gameObject != null)
			GetComponent<AudioSource> ().Play ();*/
		if (collider.gameObject.name == "Player") {
			GetComponent<AudioSource> ().Play ();
			yield return new WaitForSeconds (0.25f);
			Destroy (gameObject);
			Score.score += 1;
		}

	}
}

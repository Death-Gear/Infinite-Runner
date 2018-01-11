using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization

	private Animator myAnimator;
	public Vector3 jumpforce;
	public Rigidbody rb;
	public static bool isGrounded;

	void Start () {
		isGrounded = false;
		myAnimator = GetComponent<Animator> ();
		jumpforce = new Vector3(0, 100, 0);
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!isGrounded) {
			myAnimator.SetLayerWeight (1, 1);
		}
		else if(isGrounded){
			myAnimator.SetLayerWeight (1, 0);
		}
		if (Buttons.Flip) {
			Vector3 theScale = transform.localScale;

			theScale.x *= -1;

			transform.localScale = theScale;

			Buttons.Flip = false;
		}
		if (Buttons.Run) 
		{
			myAnimator.SetBool ("Running", true);
		}
		if (!Buttons.Run) 
		{
			myAnimator.SetBool ("Running", false);
		}

		if (Buttons.Jump && isGrounded) {
			GetComponent<AudioSource> ().Play ();
			myAnimator.SetTrigger ("Jump");
			jumpforce = new Vector3 (0, 400, 0);
			rb.velocity = Vector3.zero;
			rb.AddForce (jumpforce);
			isGrounded = false;
			Buttons.Jump = false;
			myAnimator.SetLayerWeight (1, 1);
		}
		else if (isGrounded) {
			myAnimator.ResetTrigger ("Jump");
			myAnimator.SetBool ("Land", false);
			myAnimator.SetLayerWeight (1, 0);
		}
		else if (rb.velocity.y < 0) {
			myAnimator.SetBool ("Land", true);
		}
		if (transform.position.y <= -7 || transform.position.x <= -9) {
			Time.timeScale = 0f;
		}

		if (Time.timeScale == 0)
			Destroy (gameObject);

	}

	void OnCollisionStay(Collision collision){
		if(! TileControl.colliding)
			transform.Translate (Vector3.down * StoneControl.Down_speed * Time.deltaTime, Space.World);
	}
}

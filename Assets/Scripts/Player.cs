using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 10f;
	public Animator anim;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		//Movement input
		float hMove = Input.GetAxisRaw ("Horizontal");
		float vMove = Input.GetAxisRaw ("Vertical");

		//Check if the player moves
		if (hMove == 1) {
			transform.Translate (Vector2.right * speed * Time.deltaTime);
		}
		if (hMove == -1) {
			transform.Translate (Vector2.left * speed * Time.deltaTime);
		}

		if (vMove == 1) {
			transform.Translate (Vector2.up * speed * Time.deltaTime);
		}
		if (vMove == -1) {
			transform.Translate (Vector2.down * speed * Time.deltaTime);
		}

		//Check if player is attacking
		if (Input.GetButton ("Fire1")) {
			anim.SetBool ("Attack", true);
		} else {
			anim.SetBool ("Attack", false);
		}

		//Check if player is jumping
		if (Input.GetButtonDown ("Jump")) {
			anim.SetBool ("Jumping", true);
		} else {
			anim.SetBool("Jumping", false);
		}

	}
}

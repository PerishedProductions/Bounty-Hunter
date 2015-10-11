using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour {

	public GameObject talk;
	public GameObject dialog;
	

	void OnTriggerEnter2D (Collider2D other) {
		talk.SetActive (true);
	}

	void OnTriggerStay2D (Collider2D other) {
		if (Input.GetKeyDown (KeyCode.E)) {
			dialog.SetActive (true);
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		talk.SetActive (false);
	}
}

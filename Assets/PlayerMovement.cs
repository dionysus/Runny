using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private Animator animator;
	private bool isGrounded = true;

	// Use this for initialization
	void Start () {

		animator = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			if (isGrounded) {
				animator.SetTrigger ("jumpTrigger");
			}
		}

		if (Input.GetKeyDown (KeyCode.LeftShift)) {
			animator.SetBool ("isSliding", true);
		}

		if (Input.GetKeyUp (KeyCode.LeftShift)) {
			animator.SetBool ("isSliding", false);
		}
	}

	public void IsGrounded () {
		isGrounded = !isGrounded;
	}

}

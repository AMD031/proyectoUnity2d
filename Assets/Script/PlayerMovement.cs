using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	// Update is called once per frame
	void Update () {
		ActivateRun();
		ActivateJump();
		Activatefire();

	}





	void ActivateRun()
	{
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		animator.SetFloat("speed", Mathf.Abs(horizontalMove));

	}


	void ActivateJump()
	{
		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("jump", jump);
		}

	}


	void ActivateCrouch()
	{
		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		}
		else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}
	}



	 void Activatefire()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			animator.SetBool("shoot", true);
		}
		else if (Input.GetButtonUp("Fire1"))
		{
			animator.SetBool("shoot", false);
		}

	}





	public void OnLanding ()
	{
		animator.SetBool("jump", false);
	}

	/*public void OnCrouching (bool isCrouching)
	{
		//animator.SetBool("IsCrouching", isCrouching);
	}*/

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
}

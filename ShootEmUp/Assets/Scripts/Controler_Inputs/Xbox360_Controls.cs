using UnityEngine;
using System.Collections;

public class Xbox360_Controls : MonoBehaviour {

	public float PlayerMovementSpeed = 6.0f;
	public float PlayerRotationSpeed = 180;


	public string HorizontalAxis = "Horizontal";
	public string VerticalAxis = "Vertical";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Movement ();
		UserInputs ();

	}

	void Movement ()
	{
		transform.position += (Vector3.right * Input.GetAxis (HorizontalAxis) + Vector3.forward * Input.GetAxis (VerticalAxis)).normalized *PlayerMovementSpeed* Time.deltaTime;

	}


	void UserInputs()
	{
		if (Input.GetButtonDown ("360_AButton")) 
		{
			Debug.Log("A Button");
		}

		if (Input.GetButtonDown ("360_BButton")) 
		{
			Debug.Log("B Button");
		}

		if (Input.GetButtonDown ("360_XButton")) 
		{
			Debug.Log("X Button");
		}

		if (Input.GetButtonDown ("360_YButton")) 
		{
			Debug.Log("Y Button");
		}

		if (Input.GetButtonDown ("360_LeftBumper")) 
		{
			Debug.Log("Left Bumper");
		}

		if (Input.GetButtonDown ("360_RightBumper")) 
		{
			Debug.Log("Right Bumper");
		}

		if (Input.GetButtonDown ("360_BackButton")) 
		{
			Debug.Log("Back Button");
		}

		if (Input.GetButtonDown ("360_StartButton")) 
		{
			Debug.Log("Start Button");
		}

		if (Input.GetButtonDown ("360_LeftThumbstickButton")) 
		{
			Debug.Log("Left Thumbstick Button");
		}

		if (Input.GetButtonDown ("360_RightThumbstickButton")) 
		{
			Debug.Log("Right Thumbstick Button");
		}

		// Triggers

		if (Input.GetAxis ("360_Triggers")>0.001) 
		{
			Debug.Log("Right Trigger");
		}

		if (Input.GetAxis ("360_Triggers")<0) 
		{
			Debug.Log("Left Trigger");
		}

		if (Input.GetAxis ("360_HorizontalDPAD")>0.001)  
		{
			Debug.Log("Right D-PAD Button");
		}

		if (Input.GetAxis ("360_HorizontalDPAD")<0)  
		{
			Debug.Log("Left D-PAD Button");
		}

		if (Input.GetAxis ("360_VerticalDPAD")>0.001) 
		{
			Debug.Log("Up D-PAD Button");
		}

		if (Input.GetAxis ("360_VerticalDPAD")<0) 
		{
			Debug.Log("Down D-PAD Button");
		}


	}


}

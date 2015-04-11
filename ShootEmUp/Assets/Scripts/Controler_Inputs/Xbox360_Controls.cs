using UnityEngine;
using System.Collections;

public class Xbox360_Controls : MonoBehaviour {

	public float PlayerMovementSpeed = 30;
	public float PlayerRotationSpeed = 180;

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
		transform.Translate (0, 0,Input.GetAxis ("Vertical") * Time.deltaTime * PlayerMovementSpeed);

		transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime * PlayerMovementSpeed,0,0);

		transform.Rotate (0,Input.GetAxis ("RightStick") * Time.deltaTime * PlayerRotationSpeed,0);
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

using UnityEngine;
using System.Collections;

public class Player_Shooting : MonoBehaviour {

	public float PlayerShootDelay = 0.1f;

	public GameObject PlayerBullet;
	
	private bool CanShoot = true;
	
	public string HorizontalAxis = "Horizontal";
	public string VerticalAxis = "Vertical";


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		Vector3 ShootDirection = Vector3.right * Input.GetAxis (HorizontalAxis) + Vector3.forward * Input.GetAxis (VerticalAxis);
		transform.rotation = Quaternion.LookRotation(ShootDirection,Vector3.up);
		if (CanShoot && ShootDirection.sqrMagnitude > 0.0f) 
		{
			Instantiate(PlayerBullet,transform.position,transform.rotation);
			
			CanShoot = false;
			Invoke("ResetShot",PlayerShootDelay);
		}

	}
	void ResetShot () 
	{
		CanShoot = true;
	}
}

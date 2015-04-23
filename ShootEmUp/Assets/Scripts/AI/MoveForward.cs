using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	public float Speed = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position += transform.forward*Speed*Time.deltaTime;
	}
}

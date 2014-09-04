using UnityEngine;
using System.Collections;

public class Playercontrols : MonoBehaviour {

	public float playerx;
	public float playery;
	public float playerspeed=0;



	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {
	
		playerx = Input.GetAxis("Horizontal");
		playery = Input.GetAxis("Vertical");

	}

	void FixedUpdate()
	{
		rigidbody.AddForce(playerx* playerspeed, playery * playerspeed, 0,ForceMode.Acceleration);
	}
}

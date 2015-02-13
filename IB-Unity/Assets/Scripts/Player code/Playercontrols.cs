using UnityEngine;
using System.Collections;

public class Playercontrols : MonoBehaviour {

	public float playerx;
	public float playery;
	public float playerspeed=0;

	//testcode
	public Vector3 mouseloc;
	public float zdis = 0;

	// Use this for initialization
	void Start () {
		//testcode

		//testcode
		}
	
	// Update is called once per frame
	void Update () {
	
		//test code
		mouseloc = Input.mousePosition;
		transform.LookAt (Camera.main.ScreenToWorldPoint( new Vector3 (mouseloc.x,mouseloc.y,zdis)));


		//testcode
		playerx = Input.GetAxis("Horizontal");
		playery = Input.GetAxis("Vertical");

	}

	void FixedUpdate()
	{
			rigidbody.AddForce(playerx* playerspeed, playery * playerspeed, 0,ForceMode.Force);
	}
}

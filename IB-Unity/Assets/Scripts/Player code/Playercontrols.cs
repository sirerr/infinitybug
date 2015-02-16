using UnityEngine;
using System.Collections;

public class Playercontrols : MonoBehaviour {

	public float playerx;
	public float playery;
	public float playerspeed=0;

	//testcode
	public GameObject headbone;
	public GameObject rightarm;
	//public GameObject ringtarget;

	//testcode
	public Vector3 mouseloc;
	public float zdis = 0;



	// Use this for initialization
	void Start () {
		Screen.showCursor = false;

		}
	
	// Update is called once per frame
	void LateUpdate () {

		//testcode
		headbone.transform.LookAt(Camera.main.ScreenToWorldPoint( new Vector3 (mouseloc.x,mouseloc.y,zdis)));
		headbone.transform.Rotate(0,0,-90);
		rightarm.transform.LookAt(Camera.main.ScreenToWorldPoint( new Vector3 (mouseloc.x,mouseloc.y,zdis)));
		rightarm.transform.Rotate(180,90,0);

		//test code
		mouseloc = Input.mousePosition;
	//	ringtarget.transform.position = mouseloc;

		//will move body
	//	transform.LookAt (Camera.main.ScreenToWorldPoint( new Vector3 (mouseloc.x,mouseloc.y,zdis)));

		playerx = Input.GetAxis("Horizontal");
		playery = Input.GetAxis("Vertical");

	}

	void FixedUpdate()
	{
			rigidbody.AddForce(playerx* playerspeed, playery * playerspeed, 0,ForceMode.VelocityChange);
	}
}

using UnityEngine;
using System.Collections;

public class Playerattack : MonoBehaviour {

	private Transform attackpoint;
	public GameObject attackobj;
	public float attackspeed = 0;
	//stop to many shots
	private bool waiter = true;

	
	void Start()
	{
		attackpoint = gameObject.transform.Find("emitter").gameObject.transform;
	}
	void FixedUpdate()
	{
		if(Input.GetAxis("Attack") == 1 && waiter)
		{
			float attackvel = 10f;
			GameObject attack1;
			attack1 = Instantiate(attackobj, attackpoint.transform.position,attackpoint.transform.rotation) as GameObject;
		//	attack1.rigidbody.transform.Translate(0,0,attackspeed);
			waiter = false;
			StartCoroutine(Waitbetweenshot());
		}
	}

	IEnumerator Waitbetweenshot()
			{
		yield return new WaitForSeconds(.2f);
		waiter = true;
			}

}

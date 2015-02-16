using UnityEngine;
using System.Collections;

public class Playerattack : MonoBehaviour {

	public GameObject attackpoint;
	public GameObject attackobj;
	public float attackspeed = 0;
	//stop to many shots
	private bool waiter = true;

	
	void Start()
	{
	}
	void FixedUpdate()
	{
		if(Input.GetMouseButton(0) && waiter)
		{
			GameObject attack1;
			attack1 = Instantiate(attackobj, attackpoint.transform.position,attackpoint.transform.rotation) as GameObject;
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

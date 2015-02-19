using UnityEngine;
using System.Collections;

public class Playerattack : MonoBehaviour {

	public GameObject attackpoint;
	public GameObject attackobj;
	public float attackspeed = 0;
	//stop to many shots
	private bool waiter = true;

	//testcode
	public PlayerPowers powerupref;
	public GameObject gatherenergyps;
	public GameObject powerupattack1;
	public bool getpoweredup = false;
	//testcode
	
	void Start()
	{
		powerupref = gameObject.GetComponent<PlayerPowers>();
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

		if(Input.GetMouseButton(1))
		{
			if(powerupref.powercounter != 0 && getpoweredup!= true )
			{
				getpoweredup = true;
				powerupref.powercounter--;
				StartCoroutine(Waitthenshoot());
			}

		}
	}

	IEnumerator Waitthenshoot()
	{
		GameObject gatherer;

	gatherer = Instantiate(gatherenergyps,attackpoint.transform.position,attackpoint.transform.rotation) as GameObject;
		gatherer.transform.parent = attackpoint.transform;
		yield return new WaitForSeconds(3f);
		Instantiate(powerupattack1,attackpoint.transform.position,attackpoint.transform.rotation);
		powerupref.powerpack1[powerupref.powercounter].gameObject.SetActive(false);
		getpoweredup = false;
	}
	

	IEnumerator Waitbetweenshot()
			{
		yield return new WaitForSeconds(.2f);
		waiter = true;
			}

}

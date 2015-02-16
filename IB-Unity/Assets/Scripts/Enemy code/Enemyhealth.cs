using UnityEngine;
using System.Collections;

public class Enemyhealth : MonoBehaviour {

	public int ehealth =0;
	public int ehealthtemp;
	public GameObject edamageps;

	// Use this for initialization
	void Start () {
		ehealthtemp = ehealth;
	}
	
	// Update is called once per frame
	void Update () {
	
		if(ehealth <=0)
		{
			Destroy(transform.parent.gameObject);

			Spawnsystem.deadenemy = true;
		}
	}

	void OnCollisionEnter(Collision other)
	{
		int hitcounter = 0;
		ContactPoint ehit;
		ehit = other.contacts[hitcounter];

		Instantiate(edamageps,ehit.point,transform.rotation);

		if(other.collider.tag == "pattack1")
		{
			ehealth = ehealth -1;
		}

	}
}

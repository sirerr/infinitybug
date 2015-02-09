using UnityEngine;
using System.Collections;

public class Enemyhealth : MonoBehaviour {

	public int ehealth =0;
	public int ehealthtemp;

	// Use this for initialization
	void Start () {
		ehealthtemp = ehealth;
	}
	
	// Update is called once per frame
	void Update () {
	
		if(ehealth <=0)
		{
			Destroy(this.gameObject);
			Spawnsystem.deadenemy = true;
		}
	}

	void OnCollisionEnter(Collision other)
	{
		print("hit");

		if(other.collider.tag == "pattack1")
		{
			ehealth = ehealth -1;
		}
	}
}

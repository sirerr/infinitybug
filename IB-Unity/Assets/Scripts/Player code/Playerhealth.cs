using UnityEngine;
using System.Collections;

public class Playerhealth : MonoBehaviour {


	public int phealth;
	public int attackdamage1;
	public int attackdamage2;
	private int healthtemp;
	public GameObject playerspawnlocation;
	public int playerlives = 0;

	void Start()
	{
		healthtemp = phealth;
	}

	void Update()
	{
		if(phealth <= 0)
		{
			//phealth = healthtemp;
			transform.position = playerspawnlocation.transform.position;
			phealth = healthtemp;

		}

	}
	void OnCollisionEnter(Collision other)
	{
		if(!gameObject.transform.Find("shield").gameObject.activeSelf)
		{
			if(other.collider.tag == "eattack1")
			{
				phealth = phealth - attackdamage1;
			//	print ("attacked");
			}
			
			if(other.collider.tag == "eattack2")
			{
				phealth = phealth - attackdamage2;
			}
		}


	}

}

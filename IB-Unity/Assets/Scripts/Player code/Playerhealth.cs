using UnityEngine;
using System.Collections;

public class Playerhealth : MonoBehaviour {


	public float phealth;
	public float attackdamage1;
	public float attackdamage2;
	private float healthtemp;
	public GameObject playerspawnlocation;
	public int playerlives = 0;
	public float pubhealth = 0;

	void Start()
	{
		pubhealth = phealth;
		healthtemp = phealth;
	}

	void Update()
	{
		if(phealth <= 0)
		{
			 
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
				pubhealth = phealth;

				//testcode
				HudGP.meterdistancespeed = .6f;
				//testcode
		
			}
			else
			{
				//testcode
				HudGP.meterdistancespeed = 1f;
				//testcode
			}
			
			if(other.collider.tag == "eattack2")
			{

				phealth = phealth - attackdamage2;
				pubhealth = phealth;
			}

			if(other.collider.tag == "Enemy")
			{

			}
		}


	}

}

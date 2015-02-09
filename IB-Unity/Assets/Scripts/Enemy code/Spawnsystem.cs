﻿using UnityEngine;
using System.Collections;

public class Spawnsystem : MonoBehaviour {

	public GameObject[] espawnpoints; //array of points
	public GameObject enemy1; //enemy
	public int totalspawnpoints; //amount of spawn locations
	public int chosenspawnpoint; //chosen point
	public GameObject[] aliveenemy; //current enemy alive in area
	public static bool deadenemy = false;


	// Use this for initialization
	void Start () {
		totalspawnpoints = espawnpoints.Length;
		aliveenemy[0] = enemy1;
		chosenspawnpoint = Random.Range(0,totalspawnpoints-1);
		Instantiate(aliveenemy[0],espawnpoints[chosenspawnpoint].transform.position,espawnpoints[chosenspawnpoint].transform.rotation);
	}

	public void MakeE()
	{
		chosenspawnpoint = Random.Range(0,totalspawnpoints-1);
		Instantiate(aliveenemy[0],espawnpoints[chosenspawnpoint].transform.position,espawnpoints[chosenspawnpoint].transform.rotation);
		deadenemy = false;
	}

	// Update is called once per frame
	void Update () {

		if(deadenemy)
		{
			MakeE();
		}
	
	}


}

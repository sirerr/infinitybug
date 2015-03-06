using UnityEngine;
using System.Collections;

public class Spawnsystem : MonoBehaviour {

	public GameObject[] espawnpoints; //array of points
	public GameObject enemy1; //enemy
	public int totalspawnpoints; //amount of spawn locations
	public int chosenspawnpoint; //chosen point
	public GameObject[] aliveenemy; //current enemy alive in area
	public static bool deadenemy = false;

	//testcode
	public static int createpowerupcounter = 0;
	public static int powerupdeadcounter = 5;
	//testcode


	// Use this for initialization
	void Start () {

		espawnpoints = GameObject.FindGameObjectsWithTag("espawnp");

		totalspawnpoints = espawnpoints.Length;
		aliveenemy[0] = enemy1;
		chosenspawnpoint = Random.Range(0,totalspawnpoints-1);
		for(int i = 0; i<totalspawnpoints; i++)
		{
			Instantiate(enemy1,espawnpoints[i].transform.position,espawnpoints[i].transform.rotation);
		}

		StartCoroutine(createlooper());
	}

	public void MakeE()
	{
//		chosenspawnpoint = Random.Range(0,totalspawnpoints-1);
//		Instantiate(aliveenemy[0],espawnpoints[chosenspawnpoint].transform.position,espawnpoints[chosenspawnpoint].transform.rotation);
//		deadenemy = false;

		//looper code
		for(int i = 0; i<totalspawnpoints; i++)
		{
			Instantiate(enemy1,espawnpoints[i].transform.position,espawnpoints[i].transform.rotation);
		}

		StartCoroutine(createlooper());
		//loopercode



	}

	// Update is called once per frame
	void Update () {

		if(deadenemy)
		{
	//		MakeE();
		}
	
	}

	IEnumerator createlooper()
	{
		yield return new WaitForSeconds(5f);
		MakeE();
	}


}

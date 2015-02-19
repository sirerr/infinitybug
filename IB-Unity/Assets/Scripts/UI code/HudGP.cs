using UnityEngine;
using System.Collections;

public class HudGP : MonoBehaviour {

	public UIProgressBar playerhealthbar;
	private Playerhealth playerhealthref;
	public float healthtemp = 0f;
	public float fullhealth = 0;
	public float healthstepper = 0;

	//testcode
	public float totalmeterdistance = 0;
	public static float meterdistancespeed = 1;
	public UILabel distancelabel;
	public float timepermeters = 0;
	//testcode
	public int gameplaytime = 0;
	public int gameplaylimit = 0;
	public UILabel endgame;
	public GameObject spawnsystemref;
	//testcode



	// Use this for initialization
	void Start () {
		spawnsystemref = GameObject.Find("Spawnsystem");

		playerhealthref = GameObject.FindWithTag("Player").GetComponent<Playerhealth>();
		fullhealth = playerhealthref.pubhealth;
		healthtemp = playerhealthref.pubhealth;
		playerhealthbar.numberOfSteps = Mathf.FloorToInt(fullhealth);
		healthstepper = 1f/(playerhealthbar.numberOfSteps);
	
		//test code
		distancelabel.text = totalmeterdistance.ToString();
		//test code
		StartCoroutine(incdistance());

		StartCoroutine(Ltime());
		//testcode
	}
	
	// Update is called once per frame
	void Update () {


		//healthbar code
		healthtemp = playerhealthref.pubhealth;
		playerhealthbar.value = healthtemp/fullhealth;

		if(healthtemp <=0)
		{
			playerhealthbar.value =1;
			healthtemp = fullhealth;
		}

		//testcode

		//testcode


	}

	public void distancego()
	{
		StartCoroutine(incdistance());
	}


	IEnumerator incdistance()
	{
	yield return new WaitForSeconds(timepermeters);
	totalmeterdistance = meterdistancespeed + totalmeterdistance;
	distancelabel.text = totalmeterdistance.ToString() + " M";
	
		distancego();

	}

	public void Leveltime()
	{
		StartCoroutine(Ltime());

	}

	IEnumerator Ltime()
	{
		if(gameplaytime!=gameplaylimit)
		{
			yield return new WaitForSeconds(1f);
			gameplaytime = gameplaytime +1;	
			Leveltime();
		}
		else
		{
			StopCoroutine(incdistance());
			spawnsystemref.gameObject.SetActive(false);
			endgame.gameObject.SetActive(true);
			yield return new WaitForSeconds(5f);
			Application.LoadLevel("Area1");
		}


	}
}

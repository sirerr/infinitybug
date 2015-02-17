using UnityEngine;
using System.Collections;

public class HudGP : MonoBehaviour {

	public UIProgressBar playerhealthbar;
	private Playerhealth playerhealthref;
	public float healthtemp = 0f;
	public float fullhealth = 0;
	public float healthstepper = 0;

	//testcode
	public float meterdistance;
	public int playertime;


	//testcode



	// Use this for initialization
	void Start () {
		playerhealthref = GameObject.FindWithTag("Player").GetComponent<Playerhealth>();
		fullhealth = playerhealthref.pubhealth;
		healthtemp = playerhealthref.pubhealth;
		playerhealthbar.numberOfSteps = Mathf.FloorToInt(fullhealth);
		healthstepper = 1f/(playerhealthbar.numberOfSteps);
	
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

		//powerbar code


	}
}

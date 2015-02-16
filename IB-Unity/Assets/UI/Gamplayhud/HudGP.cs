using UnityEngine;
using System.Collections;

public class HudGP : MonoBehaviour {

	public UIProgressBar playerhealthbar;
	private Playerhealth playerhealthref;
	//testing
	public float healthtemp = 0f;
	public float fullhealth = 0;

	// Use this for initialization
	void Start () {
		playerhealthref = GameObject.FindWithTag("Player").GetComponent<Playerhealth>();
		fullhealth = playerhealthref.pubhealth;
		healthtemp = playerhealthref.pubhealth;
		playerhealthbar.numberOfSteps = Mathf.FloorToInt(fullhealth);
	}
	
	// Update is called once per frame
	void Update () {

		healthtemp = playerhealthref.pubhealth;

		if(healthtemp ==0)
		{
			playerhealthbar.value =1;
		}

	}
}

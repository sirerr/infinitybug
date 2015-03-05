using UnityEngine;
using System.Collections;

public class Ewall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision enemypass)
	{
		if(enemypass.gameObject.tag == "Enemy")
		{	 
			Destroy(enemypass.transform.root.gameObject);
		}
	}
}

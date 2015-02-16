using UnityEngine;
using System.Collections;

public class Enemyattack : MonoBehaviour {

	//attacks
	public GameObject eattackobj;
	public int eattackspeed;

//	public GameObject eattack2;
	

	// Use this for initialization
	void Start () {
		StartCoroutine(waitandattack());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void attacking()
	{
		StartCoroutine(waitandattack());
	}

	IEnumerator waitandattack()
	{
		yield return new WaitForSeconds(1f);

		GameObject eattack1;

		eattack1 = Instantiate(eattackobj, gameObject.transform.position,transform.rotation) as GameObject;
		eattack1.rigidbody.velocity = new Vector3 (0,0,eattackspeed);
		attacking();
	}
}

using UnityEngine;
using System.Collections;

public class PlayerPowers : MonoBehaviour {

	//testcode
	public UITexture[] powerpack1;
	public int powercounter = 0;
	public int powerlimit = 0;

	//testcode


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

void OnCollisionEnter(Collision powerhit)
	{

		if(powerhit.collider.tag =="Powerup")
		{
		//	print ("got power up");
			if(powercounter !=powerlimit )
			{
				powercounter++;
				powerpack1[powercounter -1].gameObject.SetActive(true);

			}
		}

	}
}

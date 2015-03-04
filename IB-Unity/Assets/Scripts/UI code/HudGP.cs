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
	public string cursor1;
	public UIAtlas hudatlas;
	//testcode
	public UISprite spriteCursor;
	public Camera nguiCamera;
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
	//test function

	public static Vector3 GetScreenToGuiSpace(Vector3 pos, Transform localSpace, Camera cameraNGUI){
	
		// Since the screen can be of different than expected size, we want to convert
		// mouse coordinates to view space, then convert that to world position.
		pos.x = Mathf.Clamp01(pos.x / cameraNGUI.pixelWidth);
		pos.y = Mathf.Clamp01(pos.y / cameraNGUI.pixelHeight);


		//PROJECT INTO WORLD SPACE
		Vector3 posWorld = cameraNGUI.ViewportToWorldPoint(pos);//ABSOLUTE

		//CONVERT WORLD SPACE TO LOCAL SPACE
		return localSpace.InverseTransformPoint(posWorld);
		
		
	}
	//test function



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
		Vector3 vec1= GetScreenToGuiSpace( Input.mousePosition, spriteCursor.transform.parent, nguiCamera);
		vec1.z = 0;
		spriteCursor.transform.localPosition  = vec1;

//		UICursor.Set(hudatlas, cursor1);
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
	distancelabel.text = totalmeterdistance.ToString(".00") + " M";
	
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

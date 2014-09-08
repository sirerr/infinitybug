using UnityEngine;
using System.Collections;

public class Gamemodeselection : MonoBehaviour {

	//one or two player
	public static int gamemode = 1;


	public void oneplayer()
	{
		Application.LoadLevel("Area1");
	}

	public void twoplayer()
	{
		gamemode = 2;
		Application.LoadLevel("Area1");
	}

}

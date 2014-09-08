using UnityEngine;
using System.Collections;

public class Cameramovement : MonoBehaviour {
	
	//speeds
	public int zspeed;
	public int yspeed;
	public int xspeed;
	
	//third choice speed
	public int thirdchoicemin;
	public int thirdchoicemax;
	
	//random generation
	public int level1choice = 0;
	public int level2choice = 0;
	public int level3choice = 0;
	
	//random time gen
	private float changedirection = 0;
	public float changetimemin = 0;
	public float changetimemax = 0;
	
	
	// Use this for initialization
	void Start () {
		changedirection = Random.Range(1,5);
		StartCoroutine(Timetochange());
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate(xspeed,yspeed,100);
		
	}
	
	IEnumerator Timetochange()
		
	{
		changedirection = Random.Range(changetimemin,changetimemax);
		yield return new WaitForSeconds(changedirection);
		print("in corotine");
		firstchoice();
	}
	
	public void firstchoice()
	{
		level1choice = Random.Range(-10,10);
		secondchoice();
	}
	
	public void secondchoice()
		
	{
		if(level1choice < 0)
		{
			level2choice = Random.Range(-1,1);
			xspeed = 1;
			yspeed = 0;
		}
		
		if(level1choice > 0)
		{
			level2choice = Random.Range(-1,1);
			yspeed =1;
			xspeed =0;
		}
		thirdchoice();
	}
	
	public void thirdchoice()
		
	{
		if(xspeed == 1)
		{
			level3choice = Random.Range(thirdchoicemin,thirdchoicemax);
			xspeed = level3choice * level2choice; 
		}
		
		if(yspeed == 1)
			
		{
			level3choice = Random.Range(thirdchoicemin,thirdchoicemax);
			yspeed = level3choice * level2choice;
		}
		
		StartCoroutine(Timetochange());
	}
}

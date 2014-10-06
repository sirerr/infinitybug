﻿using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {

	public Animator playeranim;
	public bool defend = false;
	public GameObject playershield;

	// Use this for initialization
	void Start () {
		playeranim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
		playeranim.SetBool("indefense",defend);

		if(Input.GetAxis("Defense") >0f )
		   {
			defend = true;
			playershield.gameObject.SetActive(true);
			}

		if(Input.GetAxis("Defense") == 0)
		{
			defend = false;
			playershield.gameObject.SetActive(false);
		}
	}
}
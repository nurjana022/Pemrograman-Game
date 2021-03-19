﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
	
	public float bulletspeed;

	Rigidbody2D myRB;

	// Use this for initialization
	void Awake () {
		myRB = GetComponent<Rigidbody2D>();
		if(transform.localRotation.z>0)
		myRB.AddForce(new Vector2(-1,0)*bulletspeed, ForceMode2D.Impulse);
	else myRB.AddForce(new Vector2(1,0)*bulletspeed, ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

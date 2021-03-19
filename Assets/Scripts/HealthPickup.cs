﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour {
	
	public float healthAmount;
	public AudioClip deathKnell;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			playerHealth theHealth = other.gameObject.GetComponent<playerHealth>();
			theHealth.addHealth(healthAmount);
			AudioSource.PlayClipAtPoint (deathKnell, transform.position);
			Destroy(gameObject);

		}
	}
}

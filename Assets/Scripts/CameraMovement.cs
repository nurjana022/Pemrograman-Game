﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement: MonoBehaviour {

	private Vector2 velocity;
	
	public float smoothtimeY;
	public float smoothtimeX;
	
	public GameObject player;
	
	public bool bounds;
	
	public Vector3 minCameraPos;
	public Vector3 maxCameraPos;
	
	void Start () {
			
			player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void FixedUpdate()
	{
		float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothtimeX);
		float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothtimeY);
		
		transform.position = new Vector3(posX, posY, transform.position.z);
		
		if(bounds)
		{
			transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCameraPos.x, maxCameraPos.x),
				Mathf.Clamp(transform.position.z, minCameraPos.z, maxCameraPos.z));
		}
	}
	
}

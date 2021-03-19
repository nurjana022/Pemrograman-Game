using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform2 : MonoBehaviour {

	private Vector3 startPosition; 
	bool up=true;
	
	// Use this for initialization
	void Start () {
	//maxSpeed = 3; 
	startPosition = transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
	MoveVertical ();	
	}
	
	void MoveVertical() {
		var temp=transform.position;
		print (up);
		if(up==true) {
			temp.y += 0.02f;
			transform.position= temp;
		if(transform.position.y >=14.4f) {
			up=false;
		}
		}
		if(up == false) {
			temp.y -= 0.02f;
			transform.position=temp;
		if(transform.position.y <=-9.8f) {
			up = true;
		}
		}
	}
		
}

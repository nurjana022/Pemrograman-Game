using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rockethit : MonoBehaviour {
	
	public float weaponDamage;
	
	Bullet myPC;
	
	//public GameObject explosionEffect;
	
	// Use this for initialization
	void Awake () {
		myPC = GetComponentInParent<Bullet>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.layer == LayerMask.NameToLayer("shootable")){
			myPC.removeForce();
			Destroy(gameObject);
			if(other.tag == "Enemy"){
				EnemyHealth hurtEnemy = other.gameObject.GetComponent<EnemyHealth>();
				hurtEnemy.addDamage(weaponDamage);
			}
		}
	}
	
	void OnTriggerStay2D(Collider2D other){
			if(other.gameObject.layer == LayerMask.NameToLayer("shootable")){
			myPC.removeForce();
			Destroy(gameObject);
			if(other.tag == "Enemy"){
				EnemyHealth hurtEnemy = other.gameObject.GetComponent<EnemyHealth>();
				hurtEnemy.addDamage(weaponDamage);
			}
		}
	}
}

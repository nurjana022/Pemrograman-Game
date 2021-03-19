using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	
	public float ballSpeed;
	
	private Rigidbody2D theRB;
	
	public GameObject bulleteffect;

	// Use this for initialization
	void Start () {
		theRB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		theRB.velocity = new Vector2(ballSpeed * transform.localScale.x, 0);
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		Instantiate(bulleteffect, transform.position, transform.rotation);
		
		Destroy(gameObject);
	}
	
	public void removeForce(){
		theRB.velocity = new Vector2(0,0);
	}
}

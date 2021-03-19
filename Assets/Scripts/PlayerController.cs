using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	public float jumpForce;

	public KeyCode left;
	public KeyCode right;
	public KeyCode jump;
	public KeyCode throwBall;

	private Rigidbody2D theRB;
	
	public Transform groundCheckPoint;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	
	public bool isGrounded;
	
	private Animator anim;
	
	//public Transform gunTip;
	//public GameObject bullet;
	//float fireRate = 0.5f;
	//float nextFire = 0f;
	
	public GameObject bullet;
	public Transform bulletPoint;
	
	// Use this for initialization
	void Start () {
		theRB = GetComponent<Rigidbody2D>();
		
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
		isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);

		if (Input.GetKey (left)) 
		{
			theRB.velocity = new Vector2 (-moveSpeed, theRB.velocity.y);
		} else if (Input.GetKey (right)) 
		{
			theRB.velocity = new Vector2 (moveSpeed, theRB.velocity.y);
		} else {
			theRB.velocity = new Vector2(0, theRB.velocity.y);
		}
		
		if (Input.GetKeyDown (jump) && isGrounded) 
		{
			theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
		}
		
		//if(Input.GetAxisRaw("Fire1")>0 fireRocket();
		//{
			
		//}
		
		if(Input.GetKeyDown(throwBall))
		{
			GameObject bulletClone = (GameObject)Instantiate(bullet, bulletPoint.position, bulletPoint.rotation);
			bulletClone.transform.localScale = transform.localScale;
			anim.SetTrigger("Shoot");
		}
		
		if(theRB.velocity.x <0)
		{
			transform.localScale = new Vector3(-0.03501381f,0.03501381f,0.03501381f);
		} else if(theRB.velocity.x > 0)
		{
			transform.localScale = new Vector3(0.03501381f,0.03501381f,0.03501381f);
		}
		
		anim.SetFloat("Speed", Mathf.Abs(theRB.velocity.x));
		anim.SetBool("Grounded", isGrounded);
	}
	
	//void fireRocket(){
	//	if(Time.time > nextFire) {
	//		nextFire = Time.time+fireRate;
	//		if(facingRight)
	//}
}

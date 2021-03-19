using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {
	
	public float fullHealth;
	public GameObject deathFX;
	public AudioClip playerHurt;
	public string Menu;
	public GameObject gameover;
	
	//Animator myAnim;
	
	float currentHealth;
	
	PlayerController controlMovement;
	public AudioClip playerDeathSound;
	AudioSource playerAS;
	
	public Slider healthSlider;
	public Image damageScreen;
	public Text gameOverScreen;
	public Text winGameScreen;

	bool damaged = false;
	Color damagedColour = new Color(0f,0f,0f,0.5f);
	float smoothColour = 5f;
	

	// Use this for initialization
	void Start () {
		currentHealth = fullHealth;
		controlMovement = GetComponent<PlayerController>();
		
		healthSlider.maxValue = fullHealth;
		healthSlider.value = fullHealth;
		
		damaged = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(damaged){
			damageScreen.color = damagedColour;
		} else {
			damageScreen.color = Color.Lerp(damageScreen.color, Color.clear, smoothColour*Time.deltaTime);
		}
		damaged = false;
		
	}
	
	public void addDamage(float damage){
		if(damage<=0)return;
		currentHealth-=damage;
		healthSlider.value = currentHealth;
		damaged = true;
		
		if(currentHealth<=0){
			makeDead();
		}
		AudioSource.PlayClipAtPoint (playerHurt, transform.position);
	}
	
	public void addHealth(float healthAmount){
		currentHealth += healthAmount;
		if(currentHealth > fullHealth) currentHealth=fullHealth;
		healthSlider.value = currentHealth;
	}
		
	public void makeDead(){
		//myAnim.SetBool("IsDead", true);
		Instantiate(deathFX, transform.position, transform.rotation);
		Destroy(gameObject);
		AudioSource.PlayClipAtPoint (playerDeathSound, transform.position);
		damageScreen.color = damagedColour;
		gameover.SetActive (true);
		Animator gameOverAnimator = gameOverScreen.GetComponent<Animator> ();
		gameOverAnimator.SetTrigger ("gameOver");
	}

	public void winGame(){
		Destroy (gameObject);
		Animator winGameAnimator = winGameScreen.GetComponent<Animator> ();
		winGameAnimator.SetTrigger ("gameOver");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalWin : MonoBehaviour {
	public GameObject textCollect;
	public GameObject nextLevel;
	public AudioSource sound;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (GameObject.FindWithTag ("Coin") == null) {
			nextLevel.SetActive (true);
			sound.Play ();
		} else {
			textCollect.SetActive (true);
			StartCoroutine (MyCoroutine ());
		}

	}
	IEnumerator MyCoroutine(){
		yield return new WaitForSeconds(3.5f);
		textCollect.SetActive (false);
	}

}
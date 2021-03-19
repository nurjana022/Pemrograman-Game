using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {

	public int pointsToAdd;
	public AudioClip deathKnell;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<PlayerController> () == null)
			return;

		ScoreManager.AddPoints (pointsToAdd);

		Destroy (gameObject);
		AudioSource.PlayClipAtPoint (deathKnell, transform.position);
	}
}

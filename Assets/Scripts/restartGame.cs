using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour {

	public GameObject GameOver;
	public string level;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void click(){
		SceneManager.LoadScene (level);
		GameOver.SetActive (false);
	}
}

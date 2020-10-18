using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour {

	float timer = 0;
	// Use this for initialization
	void Start () {
		timer += Time.deltaTime;
		if (timer > 2)
			{
			  Data.score = 0;
			  SceneManager.LoadScene("Gameplay");
		    }
		
	}
}

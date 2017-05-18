using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Borders : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		//colisión de cabeza de la serpiente a una pared
		if (other.CompareTag("SnakeHead")){  
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}

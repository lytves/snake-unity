using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TailMovement : MonoBehaviour {

	public float speed;
	//public float rotationSpeed = 75;
	public GameObject tailTarget;
	public Vector3 tailTargetPosition;
	public SnakeMovement mainSnake;
	// Use this for initialization
	public int numberTarget;
	void Start () {
		mainSnake = GameObject.FindWithTag("SnakeHead").GetComponent<SnakeMovement>();
		tailTarget = mainSnake.tailObjects[mainSnake.tailObjects.Count-2];
		numberTarget = mainSnake.tailObjects.IndexOf(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		//cada vez leemos la velocidad actual de la cabeza serpiente
		speed = mainSnake.speed + 2.5f;
		tailTargetPosition = tailTarget.transform.position;
		transform.LookAt(tailTargetPosition);
		transform.position = Vector3.Lerp(transform.position, tailTargetPosition, Time.deltaTime * speed);
	}

	void OnTriggerEnter(Collider other) {
		//colisión de cabeza de la serpiente a una parte de su cola
		if (other.CompareTag("SnakeHead") && numberTarget > 2){ 
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}

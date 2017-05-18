using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMovement : MonoBehaviour {

	public float speed = 2;
	//public float rotationSpeed = 75;
	public GameObject tailTarget;
	public SnakeMovement mainSnake;
	// Use this for initialization
	void Start () {
		mainSnake = GameObject.FindWithTag("SnakeHead").GetComponent<SnakeMovement>();
		tailTarget = mainSnake.tailObjects[mainSnake.tailObjects.Length-1];
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(tailTarget.transform);
		transform.Translate(Vector3.forward*Time.deltaTime*speed);
	}
}

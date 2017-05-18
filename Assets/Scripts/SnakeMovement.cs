using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour {

	public float speed = 2;
	public float rotationSpeed = 75;
	public GameObject[] tailObjects = new GameObject[1];
	public float zOffset = 0.6f;
	public GameObject tailPrefab;
	// Use this for initialization
	void Start () {
		tailObjects[0] = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward*speed*Time.deltaTime);
		if (Input.GetKey(KeyCode.D)){
			transform.Rotate(Vector3.up*rotationSpeed*Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A)){
			transform.Rotate(Vector3.down*rotationSpeed*Time.deltaTime);
		}
	}

	void AddTail(){
		tailObjects = new GameObject[tailObjects.Length+1];

		Vector3 newTailPosition = tailObjects[tailObjects.Length].transform.position;
		newTailPosition.z -= zOffset;

		tailObjects[tailObjects.Length] = GameObject.Instantiate(tailPrefab, newTailPosition, Quaternion.identity) as GameObject;
	}
}

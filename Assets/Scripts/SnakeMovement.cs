using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class SnakeMovement : MonoBehaviour {

	public float speed = 2.0f;
	public float rotationSpeed = 180.0f;
	public List<GameObject> tailObjects = new List<GameObject>();
	//public float zOffset = 0.6f;
	public GameObject tailPrefab;
	public Text scoreText;
	public int scoreNumber = 0;


	// Use this for initialization
	void Start () {
		tailObjects.Add(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * speed * Time.deltaTime);

		//mandar de la serpiente a través teclado
		if (Input.GetKey(KeyCode.D)){
			transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A)){
			transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
		}

		//sobreescribimos el texto UI
		scoreText.text = scoreNumber.ToString();
	}

	public void AddTail(){
		Vector3 newTailPosition = tailObjects[tailObjects.Count-1].transform.position;
		//newTailPosition.z -= zOffset;
		speed += 0.2f;
		rotationSpeed += 5.0f;
		tailObjects.Add(GameObject.Instantiate(tailPrefab, newTailPosition, Quaternion.identity) as GameObject);

		scoreNumber++;
	}
}

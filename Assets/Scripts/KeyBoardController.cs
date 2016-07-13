using UnityEngine;
using System.Collections;

public class KeyBoardController : MonoBehaviour {


	float maxSpeed = 20.0f;
	float accel = 4.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<Rigidbody> ().velocity.magnitude >= maxSpeed)
			return;
			
		if (Input.GetKeyDown (KeyCode.UpArrow))
			StartCoroutine (ChangeDirection ("Up"));
		if (Input.GetKeyDown (KeyCode.DownArrow))
			StartCoroutine (ChangeDirection ("Down"));
		if (Input.GetKeyDown (KeyCode.RightArrow))
			StartCoroutine (ChangeDirection ("Right"));
		if (Input.GetKeyDown (KeyCode.LeftArrow))
			StartCoroutine (ChangeDirection ("Left"));
	
	}


	IEnumerator ChangeDirection(string command ){
		GetComponent<Rigidbody> ().velocity = Vector3.zero;
		switch (command) {
		case "Up":
			GetComponent<Rigidbody>().AddRelativeForce(Vector3.up*accel);
			break;
		case "Down":
			GetComponent<Rigidbody>().AddRelativeForce(Vector3.down*accel);
			break;
		case "Right":
			GetComponent<Rigidbody>().AddRelativeForce(Vector3.right*accel);
			break;
		case "Left":
			GetComponent<Rigidbody>().AddRelativeForce(Vector3.left*accel);
			break;

		}
		yield return 0;
	}
}

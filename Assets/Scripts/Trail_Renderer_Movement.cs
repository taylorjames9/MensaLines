using UnityEngine;
using System.Collections;

public class Trail_Renderer_Movement : MonoBehaviour {


	float maxSpeed = 5.0f;
	float accel = 0.1f;
	bool changingDirection = false;

	void FixedUpdate () {
		if(GetComponent<Rigidbody>().velocity.magnitude <= maxSpeed)
			GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*accel);
	}



	void OnTriggerEnter(Collider other) {
		Debug.Log ("Trigger Enter");
		if (other.tag.Equals ("Direction") && !changingDirection) {
			StartCoroutine ("ChangeDirection");
		}
	}

	IEnumerator ChangeDirection( ){
		changingDirection = true;
		yield return new WaitForSeconds(0.25f);
		GetComponent<Rigidbody> ().velocity = new Vector3 (0.01f, 0.01f, 0.0f);
		int rand = UnityEngine.Random.Range (0, 3);
		int rand_interpret = 0;
		switch (rand) {
		case 0:
			rand_interpret = -90;
			break;
		case 1:
			rand_interpret = 90;
			break;
		case 2:
			rand_interpret = 180;
			break;
		case 3:
			rand_interpret = 45;
			break;

		}

		transform.Rotate (rand_interpret, 0, 0);
		yield return new WaitForSeconds(1.0f);

		changingDirection = false;

	}

}

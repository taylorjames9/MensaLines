using UnityEngine;
using System.Collections;

public class Arrow_Manager : MonoBehaviour {


	public ParticleSystem myParticleSystem;

	void OnTriggerEnter(Collider other) {
		myParticleSystem.Play ();
	}

}

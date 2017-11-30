using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class n_trigger : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		this.gameObject.GetComponent<AudioSource>().Play();
	}

}

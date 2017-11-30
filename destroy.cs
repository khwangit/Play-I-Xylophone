using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

	public Sprite up;
	public Sprite down;
	public float delay = 0.1f;
	public GameObject[] notes;

	void Start () {
		
	}

	void Update () {
		notes = GameObject.FindGameObjectsWithTag ("notes");

		if(this.gameObject.GetComponent<SpriteRenderer>().sprite == down){
			delay -= Time.deltaTime;
			if (delay <= 0) {
				this.gameObject.GetComponent<SpriteRenderer>().sprite = up;
				delay = 0.1f;
			}
		}
	}

	void OnMouseDown(){
		this.gameObject.GetComponent<SpriteRenderer>().sprite = down;

		for(int i=0; i < notes.Length; i++){
			Destroy (notes[i]);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class k_click : MonoBehaviour {

	public Sprite up;
	public Sprite down;
	public float delay = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
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
		this.gameObject.GetComponent<AudioSource>().Play();
	}
}

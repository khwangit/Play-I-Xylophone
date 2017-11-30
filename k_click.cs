using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class k_click : MonoBehaviour {

	public Sprite up;
	public Sprite down;
	public float delay = 0.1f;
	public GameObject set;
	public Transform C;
	public Transform D;
	public Transform E;
	public Transform F;
	public Transform G;
	public Transform A;
	public Transform B;
	public Transform C1;


	
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

		set.SetActive (true);

		if(this.gameObject.name == "01"){
			Instantiate (C, new Vector2 (set.transform.position.x, 0), Quaternion.identity);
		}

		if(this.gameObject.name == "02"){
			Instantiate (D, new Vector2 (set.transform.position.x, 0), Quaternion.identity);
		}

		if(this.gameObject.name == "03"){
			Instantiate (E, new Vector2 (set.transform.position.x, 0), Quaternion.identity);
		}

		if(this.gameObject.name == "04"){
			Instantiate (F, new Vector2 (set.transform.position.x, 0), Quaternion.identity);
		}

		if(this.gameObject.name == "05"){
			Instantiate (G, new Vector2 (set.transform.position.x, 0), Quaternion.identity);
		}

		if(this.gameObject.name == "06"){
			Instantiate (A, new Vector2 (set.transform.position.x, 0), Quaternion.identity);
		}

		if(this.gameObject.name == "07"){
			Instantiate (B, new Vector2 (set.transform.position.x, 0), Quaternion.identity);
		}

		if(this.gameObject.name == "08"){
			Instantiate (C1, new Vector2 (set.transform.position.x, 0), Quaternion.identity);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_click : MonoBehaviour {

	public Sprite up;
	public Sprite down;
	public Sprite s_up;
	public Sprite s_down;
	public float delay = 0.1f;
	public GameObject bar;


	// Update is called once per frame
	void Update () {

		if(this.gameObject.GetComponent<SpriteRenderer>().sprite == down){
			delay -= Time.deltaTime;
			if (delay <= 0) {
				this.gameObject.GetComponent<SpriteRenderer>().sprite = s_up;
				bar.SetActive (true);
				delay = 0.1f;
			}
		}

		if(this.gameObject.GetComponent<SpriteRenderer>().sprite == s_down || bar.transform.position.x >= 8f ){
			delay -= Time.deltaTime;
			if (delay <= 0) {
				this.gameObject.GetComponent<SpriteRenderer>().sprite = up;
				bar.SetActive (false);
				bar.transform.position = new Vector2 (-8f, 1.25f);
				delay = 0.1f;
			}
		}
	}

	void OnMouseDown(){
		if (!bar.activeSelf) {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = down;
		}

		if(bar.activeSelf){
			this.gameObject.GetComponent<SpriteRenderer>().sprite = s_down;
		}
	}

}

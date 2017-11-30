using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if(this.gameObject.transform.position.x >= 7.5f){
			this.transform.position = new Vector2 (-7.5f, 1.25f);
			this.gameObject.SetActive (false);
		}
	}
}

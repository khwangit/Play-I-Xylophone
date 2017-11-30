using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_r : MonoBehaviour {

	public float speed = 3f;

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * speed * Time.deltaTime);
	}
}

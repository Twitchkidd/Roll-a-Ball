using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		// Rotate and Translate, both options :)
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
		// This action also needs to be smooth and framerate independent,
		// hence multiplication by Time.deltaTime.
	}
}

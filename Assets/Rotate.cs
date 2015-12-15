using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public float rotationspeed = 100.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.S)) {
			transform.Rotate (0, 0, rotationspeed * Time.deltaTime);
				}
		if (Input.GetKey (KeyCode.W)) {
			transform.Rotate (0,0, -rotationspeed * Time.deltaTime);
		}

	}
}

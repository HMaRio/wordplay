using UnityEngine;
using System.Collections;

public class movescript : MonoBehaviour {
	public float speed = 1f;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {


		transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime, 0.0f, 0.0f);
	
	}
}

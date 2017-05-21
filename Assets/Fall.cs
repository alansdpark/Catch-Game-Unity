using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour {

	private float fallSpeed = 11f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.down * fallSpeed * Time.deltaTime, Space.World);
	}
}

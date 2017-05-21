﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private float playerSpeed = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate (Vector3.left * playerSpeed * Time.deltaTime, Space.World);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Translate (Vector3.right * playerSpeed * Time.deltaTime, Space.World);
		}
	}
}

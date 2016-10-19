﻿using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    public Ball ball;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = this.transform.position - ball.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (ball.transform.position.z <= 1829f) { // in front of head pin
            this.transform.position = ball.transform.position + offset;
        }
    }
}

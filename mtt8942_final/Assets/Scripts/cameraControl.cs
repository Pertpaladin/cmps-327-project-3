﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//third person camera controller
public class cameraControl : MonoBehaviour {

    private const float y_angle_min = 10.0f;
    private const float y_angle_max = 50.0f;

    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;

    private float distance = 7.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensivityX = 4.0f;
    private float sensivityY = 1.0f;

	// Use this for initialization
	void Start () {
        camTransform = transform;
        cam = Camera.main;
		
	}

    private void Update()
    {
        currentX += Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");

        currentY = Mathf.Clamp(currentY, y_angle_min, y_angle_max);
    }

    // Update is called once per frame
    void LateUpdate () {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);

	}
}

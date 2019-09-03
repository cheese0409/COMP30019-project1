﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>

public class CameraControl : MonoBehaviour
{
    public float mouse = 5.0f;
    public float keyboard = 0.1f;
    public float mouseWheel = 10f;

    private void Update()
    {
        // AWSD control
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(Input.GetAxis("Horizontal") * keyboard, 0, 0);
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(0, 0, Input.GetAxis("Vertical") * keyboard);
        }

        //Mouse control
        float mouseX = Input.GetAxis("Mouse X") * mouse;
        float mouseY = Input.GetAxis("Mouse Y") * mouse;
        Vector3 angle = new Vector3(mouseY, -mouseX, 0);
        this.transform.eulerAngles -= angle;
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private Vector3 offset;
    public GameObject player;

	void Start () {
        if( player != null ) {
           offset = transform.position - player.transform.position;
        }
    }
	
	void LateUpdate () {
        if( player != null ) {
            transform.position = player.transform.position + offset;
        }
	}
}
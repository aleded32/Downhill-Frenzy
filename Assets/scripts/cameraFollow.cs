﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

	// Use this for initialization
	public GameObject bike;
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = new Vector3(transform.position.x, bike.transform.position.y + 10, bike.transform.position.z);	
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

	// Use this for initialization
	public GameObject bike;
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = new Vector3(bike.transform.position.x + 10, bike.transform.position.y + 19, bike.transform.position.z + 7);	
	}
}

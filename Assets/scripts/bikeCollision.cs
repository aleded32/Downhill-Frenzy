using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bikeCollision : MonoBehaviour {

	public bool isTouching = false;

	void OnCollisionEnter(Collision collision) 
	{
		if (collision.collider.tag == "floor")
		{
			gameObject.GetComponent<bikeController>().force = 70;
		}

	}

	void OnCollisionExit(Collision collision) 
	{
		if (collision.collider.tag == "floor")
		{
			gameObject.GetComponent<bikeController>().force = 2;
		}


		
	}




}

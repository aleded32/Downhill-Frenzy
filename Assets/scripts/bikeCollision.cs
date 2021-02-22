using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bikeCollision : MonoBehaviour {

	public bool isTouching = false;
	public checkpointSystem cs;
	bool isChecked = false;

	void OnCollisionEnter(Collision collision) 
	{
		if (collision.collider.tag == "floor")
		{
			gameObject.GetComponent<bikeController>().accelaration = new Vector3(0,0,40);
		}

		

	}

    void OnTriggerEnter(Collider collision)
    {
		if (collision.tag == "checkpoint" && isChecked == false)
		{
			cs.addCheckpoint(collision);
			isChecked = true;
		}
	}

	void OnTriggerExit(Collider collision) 
	{
		isChecked = false;
	}

	void OnCollisionExit(Collision collision) 
	{
		if (collision.collider.tag == "floor")
		{
			gameObject.GetComponent<bikeController>().accelaration = new Vector3(0, 0, 0);
		}


		
	}




}

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


		if (collision.collider.tag == "jumpPad")
		{
			gameObject.GetComponent<Rigidbody>().velocity += new Vector3(0, 20, 2);
			
			//gameObject.GetComponent<Rigidbody>().velocity = new Vector3(gameObject.GetComponent<Rigidbody>().velocity.x, gameObject.GetComponent<Rigidbody>().velocity.y, gameObject.GetComponent<Rigidbody>().velocity.z -10);
		}

		if (collision.collider.tag == "spikes") 
		{
			
			if (gameObject.tag == "Player")
				cs.spawnAtCheckPoint(gameObject, cs.getCheckpointList(), cs.i[0]);
		}

		if (collision.collider.tag == "floor" || collision.collider.tag == "normFloor")
		{
				gameObject.GetComponent<bikeController>().accelaration = new Vector3(0, 0, 40);
			
		}


	}

	

	void OnTriggerEnter(Collider collision)
    {
		if (collision.tag == "checkpoint" && isChecked == false)
		{
			if(gameObject.tag == "Player")
			{
				cs.addCheckpoint(collision, cs.getCheckpointList(),cs.i, 0);
				isChecked = true;
			}
			
		}

        

	}

	void OnTriggerExit(Collider collision) 
	{
		isChecked = false;
	}

	void OnCollisionExit(Collision collision) 
	{
		if (collision.collider.tag == "floor" || collision.collider.tag == "jumpPad")
		{
				gameObject.GetComponent<bikeController>().accelaration = new Vector3(0, 0, 0);
		}
		
	}




}

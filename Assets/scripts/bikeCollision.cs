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
			gameObject.GetComponent<Rigidbody>().velocity += new Vector3(0, 20, 0);
			
		}

		if (collision.collider.tag == "spikes") 
		{
			
			if (gameObject.tag == "Player")
				cs.spawnAtCheckPoint(gameObject, cs.getCheckpointList(), cs.i[0]);
			else if (gameObject.tag == "AI")
				cs.spawnAtCheckPoint(gameObject, cs.getCheckpointListAI(), cs.i[1]);

		}

		if (collision.collider.tag == "floor")
		{
			if (gameObject.tag == "Player")
				gameObject.GetComponent<bikeController>().accelaration = new Vector3(0, 0, 40);
			else if (gameObject.tag == "AI")
			{
				gameObject.GetComponent<bikeAIController>().accelaration = new Vector3(0, 0, 40);
			}
				
		}

	}

	

	void OnTriggerEnter(Collider collision)
    {
		if (collision.tag == "checkpoint" && isChecked == false)
		{
			if (gameObject.tag == "AI")
			{
				cs.addCheckpoint(collision, cs.getCheckpointListAI(), cs.i, 1);
			}
			else if(gameObject.tag == "Player")
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
		if (collision.collider.tag == "floor")
		{
			if(gameObject.tag == "Player")
				gameObject.GetComponent<bikeController>().accelaration = new Vector3(0, 0, 0);
			else
				gameObject.GetComponent<bikeAIController>().accelaration = new Vector3(0, 0, 0);

		}


		
	}




}

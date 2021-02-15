using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bikeController : MonoBehaviour {

	public GameObject pivotL;
	public GameObject pivotR;
	public Rigidbody rb;
	float speed;
	public float force;
	float rotateSpeed;
	public checkpointSystem cs;


	// Use this for initialization
	void Start () 
	{
		speed = 15;
		rotateSpeed = 90;
		force = 70;
		
	}
	
	// Update is called once per frame
	void FixedUpdate() 
	{
		if (Input.GetKey(KeyCode.W))
		{
			move(force);
		}
		else if (Input.GetKey(KeyCode.S))
		{
			move(-force);
		}
		else 
		{
			
		}

		if (Input.GetKey(KeyCode.D))
		{

			rotateWheel(pivotR, Vector3.right);
		}
		else if (Input.GetKey(KeyCode.A))
		{
			rotateWheel(pivotL, Vector3.left);
		}

		restartFromCheckPoint();
	}


	void rotateWheel(GameObject pivot, Vector3 rotateAxis) 
	{
		transform.RotateAround(pivot.transform.position, rotateAxis, rotateSpeed * Time.deltaTime);
	}

	void move(float force) 
	{
		rb.AddForce(0,0,force * speed * Time.smoothDeltaTime);
	}

	void restartFromCheckPoint() 
	{
		if (Input.GetKey(KeyCode.R)) 
		{
			cs.spawnAtCheckPoint(gameObject);
			transform.rotation = new Quaternion(0, 0, 0,0);
		}
	}

	 
}

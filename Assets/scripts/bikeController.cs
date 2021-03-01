using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bikeController : MonoBehaviour {

	public GameObject pivotL;
	public GameObject pivotR;
	public Rigidbody rb;
	float speed;
	public Vector3 accelaration;
	float rotateSpeed;
	public checkpointSystem cs;
	public TimerController time;


	// Use this for initialization
	void Start () 
	{
		speed = 15;
		rotateSpeed = 200;
		accelaration = new Vector3(0,0,40);
		
	}
	
	// Update is called once per frame
	void FixedUpdate() 
	{
		if (time.start == true)
		{

			if (Input.GetKey(KeyCode.W))
			{
				move(accelaration);
			}
			else if (Input.GetKey(KeyCode.S))
			{
				move(-accelaration);
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


			if (rb.velocity.z > -10 && rb.velocity.z < 10)
				rotateSpeed = 40;
			else
				rotateSpeed = 120;

		}

		clampVelocity();

		restartFromCheckPoint();
	}


	void rotateWheel(GameObject pivot, Vector3 rotateAxis) 
	{
		transform.RotateAround(pivot.transform.position, rotateAxis, rotateSpeed * Time.deltaTime);
	}

	void move(Vector3 accelaration) 
	{
		rb.velocity += accelaration * Time.deltaTime;
	}

	void restartFromCheckPoint() 
	{
		if (Input.GetKey(KeyCode.R)) 
		{
			cs.spawnAtCheckPoint(gameObject);
			transform.rotation = new Quaternion(0, 0, 0,0);
		}
	}

	void clampVelocity() 
	{
		Mathf.Clamp(rb.velocity.z, 0, 15);
	}

	 
}

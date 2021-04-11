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
	public float rotateSpeed;
	public checkpointSystem cs;
	public TimerController time;
	public GameObject pauseMenu;
	public GameObject gameHUD;
	public bool isPaused;
	bool isPressed;
	public EndScreen end;

	// Use this for initialization
	void Start () 
	{
		speed = 15;
		rotateSpeed = 200;
		accelaration = new Vector3(0,0,40);
		isPaused = false;
		isPressed = false;
		Time.timeScale = 1.0f;
		
	}
	
	// Update is called once per frame
	void Update() 
	{
		if (time.start == true && isPaused == false)
		{
			if (!end.finishedBool)
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
					rotateSpeed = 120;
				else
					rotateSpeed = 220;

				clampVelocity();

				restartFromCheckPoint();

			}

		}

		if (Input.GetKeyDown(KeyCode.Escape) && !isPressed)
		{
			if (!isPaused)
			{
				Time.timeScale = 0.0f;
				pauseMenu.SetActive(true);
				gameHUD.SetActive(false);
				
				isPaused = true;
			}
			else if (isPaused)
			{
				pauseMenu.SetActive(false);
				gameHUD.SetActive(true);
				Time.timeScale = 1.0f;
				isPaused = false;
			}
			isPressed = true;
		}
		else 
		{
			isPressed = false;
		}

		
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
			cs.spawnAtCheckPoint(gameObject, cs.getCheckpointList(), cs.i[0]);
			transform.rotation = new Quaternion(0, 0, 0,0);
		}
	}

	void clampVelocity() 
	{
		Mathf.Clamp(rb.velocity.z, 0, 15);
	}

	 
}

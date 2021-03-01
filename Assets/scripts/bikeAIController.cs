using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bikeAIController : MonoBehaviour {

	public checkpointSystem cs;
	public Rigidbody rb;
	public TimerController time;
	public GameObject pivotL;
	public GameObject pivotR;
	public Vector3 accelaration;
	public Vector3 decelaration;

	public int checkpointPassed = 0;

	RaycastHit[] hit = new RaycastHit[3];
	int[] layerMask = new int[3];
	bool ishit = false;


	void Start ()
	{

		accelaration = new Vector3(0, 0,15);
		decelaration = new Vector3(0, 0, 155);


	}

	public void checkFloorRotation() 
	{
		layerMask[0] = 1 << 9;
		layerMask[1] = 1 << 10;
		layerMask[2] = 1 << 11;

		for (int i = 0; i < hit.Length; i++) 
		{
			if (i == 0) 
			{
				if (Physics.Raycast(transform.position, Vector3.forward, out hit[i], 5, layerMask[0]))
				{
					transform.rotation = hit[i].collider.gameObject.transform.rotation;
					Debug.DrawRay(transform.position, Vector3.forward * hit[0].distance * 100, Color.red);
				}
			}
			else if (i == 1)
			{
				if (Physics.Raycast(transform.position, Quaternion.AngleAxis(30.0f, Vector3.right) * Vector3.forward, out hit[i], 23, layerMask[1]))
				{
					
					if (rb.velocity.z > 0 && ishit == false)
					{
						rb.velocity -= decelaration * Time.deltaTime;
						
					}
					else if (rb.velocity.z <= 0) 
					{
						ishit = true;
					}
					
					Debug.DrawRay(transform.position, Quaternion.AngleAxis(30.0f, Vector3.right) * Vector3.forward * 100, Color.red);
				}
				ishit = false;

			}
			else if (i == 2)
			{
				if (Physics.Raycast(transform.position, Quaternion.AngleAxis(30.0f, Vector3.right) * Vector3.forward, out hit[i], 6, layerMask[2]))
				{
					transform.rotation = hit[i].collider.gameObject.transform.rotation;
					Debug.Log("hit");
					//Debug.DrawRay(transform.position, Vector3.forward * hit[0].distance * 100, Color.red);
				}
			}

			Debug.DrawRay(transform.position, Vector3.forward * hit[0].distance * 4, Color.green);
			Debug.DrawRay(transform.position, Quaternion.AngleAxis(30.0f, Vector3.right) * Vector3.forward * 25, Color.green);
			Debug.DrawRay(transform.position, Quaternion.AngleAxis(30.0f, Vector3.right) * Vector3.forward * 25, Color.green);

		}

		
	}
	
	void Update () 
	{
		
		if (time.start == true)
		{
			if (distFromCheckpoint(cs.getCheckpoint(checkpointPassed).transform.position, transform.position) > 0)
			{
				rb.velocity += accelaration * Time.deltaTime;
			}
			checkFloorRotation();
			clampVelocity();
		}

		
		
	}


	float distFromCheckpoint(Vector3 csPos, Vector3 AIPos) 
	{
		return Vector3.Distance(AIPos, csPos);
	}

	void clampVelocity()
	{
		Mathf.Clamp(rb.velocity.z, 0, 15);
	}

}

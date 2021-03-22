using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class topBikeCollision : MonoBehaviour {

	// Use this for initialization
	public checkpointSystem cs;

	void OnCollision(Collision collision)
	{
		if (collision.collider.tag == "floor")
		{
			cs.spawnAtCheckPoint(gameObject, cs.getCheckpointList(), cs.i[0]);
			Debug.Log(1);
		}

	}

	
}

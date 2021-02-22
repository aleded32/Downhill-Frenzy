using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointSystem : MonoBehaviour {

	[SerializeField]
	List<GameObject> checkpointPassed;

	GameObject currentCheckpoint;
	int i = -1;
	 int finishedCheckpoint = 3;


	public void spawnAtCheckPoint(GameObject player)
	{
		if (i >= 0)
			player.transform.position = checkpointPassed[i].transform.position;

	}

	public void addCheckpoint(Collider colider)
	{
		currentCheckpoint = colider.gameObject;
		if (checkpointPassed.Find(x => x.name == colider.gameObject.name) != true || checkpointPassed.Count <= 0)
		{
			checkpointPassed.Add(currentCheckpoint);
			i++;
		}


	}

	public int getCurrentCheckpoint() 
	{
		return checkpointPassed.Count;
	}
	public int getFinishedCheckpoint()
	{
		return finishedCheckpoint;
	}

}

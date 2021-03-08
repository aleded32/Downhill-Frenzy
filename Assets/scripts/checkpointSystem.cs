using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointSystem : MonoBehaviour {

	[SerializeField]
	List<GameObject> checkpointPassed;
	[SerializeField]
	List<GameObject> checkpointPassedAI;
	[SerializeField]
	public GameObject[] checkpointList;

	GameObject currentCheckpoint;
	public int[] i = {-1,  -1};
	int finishedCheckpoint = 3;


	
	


	public void spawnAtCheckPoint(GameObject player, List<GameObject> checkpointList, int previousCheckpoint)
	{
		if (previousCheckpoint >= 0)
            player.transform.position = checkpointList[previousCheckpoint].transform.position;

	}

	public void addCheckpoint(Collider colider, List<GameObject> checkpointPassed, int[] previousCheckpoint, int i)
	{
		currentCheckpoint = colider.gameObject;
		if (checkpointPassed.Find(x => x.name == colider.gameObject.name) != true || checkpointPassed.Count <= 0)
		{
			checkpointPassed.Add(currentCheckpoint);
			previousCheckpoint[i]++;
		}


	}

	public List<GameObject> getCheckpointList() 
	{
		return checkpointPassed;
	}

	public List<GameObject> getCheckpointListAI()
	{
		return checkpointPassedAI;
	}

	public int getCurrentCheckpoint() 
	{
		return checkpointPassed.Count;
	}
	public int getFinishedCheckpoint()
	{
		return finishedCheckpoint;
	}

	public GameObject getCheckpoint(int j) 
	{
		return checkpointList[j];
	}

}

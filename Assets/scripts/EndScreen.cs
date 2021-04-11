using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndScreen : MonoBehaviour 
{

	public checkpointSystem cs;
	public GameObject endScreen;
	public bool finishedBool;

	void Start() 
	{
		finishedBool = false;
	}

	// Update is called once per frame
	void Update () 
	{
		finished();
	}

	void finished() 
	{
		if (passedFinishLine()) 
		{
			finishedBool = true;
			endScreen.SetActive(true);
		}
	}

	bool passedFinishLine() 
	{
		if (cs.getCurrentCheckpoint() >= cs.getFinishedCheckpoint())
		{
			return true;
		}
		else
			return false;
	}

	public void quit() 
	{
		SceneManager.LoadScene("startMenu");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerController : MonoBehaviour {

	public bool start;
	public float time;
	public float timer;
	public float minutes, hours;
	checkpointSystem cs;

	// Use this for initialization
	void Start () 
	{
		start = false;
		time = 3;
		timer = 0;
		cs = GameObject.FindWithTag("checkpointManager").GetComponent<checkpointSystem>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		startTimer();


		if (cs.getCurrentCheckpoint() < cs.getFinishedCheckpoint() && start == true)
		{
			recordTime();
		}
		else if(cs.getCurrentCheckpoint() >= cs.getFinishedCheckpoint() && start == true) 
		{
			Debug.Log(cs.getCurrentCheckpoint());
		}

		

		
		
		
	}

	void startTimer() 
	{
		
		if (time < 1)
		{
			start = true;
			time = 0;
		}
		else if(time <= 3 && time > 0)
		{
			time -= Time.deltaTime;
		}
	}

	void recordTime() 
	{
		timer += Time.deltaTime;

		if (timer > 60)
		{
			minutes ++;
			timer = 0;
		}
		else if (minutes > 60) 
		{
			hours++;
			minutes = 0;
			timer = 0;
		}
	}

}

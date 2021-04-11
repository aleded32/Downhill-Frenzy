using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishedTime : MonoBehaviour {

	public TimerController t;
	public Text finishedTimeText;
	
	// Update is called once per frame
	void Update () 
	{
		finishedTime();
	}


	void finishedTime() 
	{
		finishedTimeText.text = "Time : " + t.hours + "." + t.minutes + "." + t.timer.ToString("f0");
	}
}

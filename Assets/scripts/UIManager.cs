using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	// Use this for initialization
	public Text checkpointText;
	public Text TimerText;
	public Text startTimerText;
	public checkpointSystem cs;
	public TimerController timer;

	bool disableStartTimer = false;
	
	// Update is called once per frame
	void Update ()
	{
		UpdatecheckpointText();
		UpdateStartTimerText();
		UpdateTimerText();
	}


	void UpdatecheckpointText() 
	{
		checkpointText.text = "checkpoints: " + (cs.getCurrentCheckpoint()) + " / " +cs.getFinishedCheckpoint(); 
	}

	void UpdateTimerText()
	{
		TimerText.text = timer.hours.ToString("f0") + "." + timer.minutes.ToString("f0") + "." + timer.timer.ToString("f0");
	}

	void UpdateStartTimerText() 
	{
		if (timer.time < 1 && timer.time > 0 && disableStartTimer == false)
		{
			startTimerText.text = "GO";
		}
		else if (timer.time <= 0 && timer.timer > 1) 
		{
			
			startTimerText.text = "";
			disableStartTimer = true;

		}
		else if (disableStartTimer == false && timer.time > 0)
		{
			startTimerText.text = timer.time.ToString("f0");
		}
		
	}

}

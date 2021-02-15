using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	// Use this for initialization
	public Text checkpointText;
	public checkpointSystem cs;
	
	// Update is called once per frame
	void Update ()
	{
		UpdatecheckpointText();
	}


	void UpdatecheckpointText() 
	{
		checkpointText.text = "checkpoints: " + (cs.i + 1) + " / 4"; 
	}
}

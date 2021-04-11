using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerPosition : MonoBehaviour {


	int playerCurrentPosition;
	public GameObject player, ai;
	public EndScreen end;
	public Text finishedPositionText;
	public Text currentPosText;

	// Use this for initialization
	void Start () 
	{
		playerCurrentPosition = 1;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		positioning();
		currentPos();
	}

	void positioning() 
	{
		if (!end.finishedBool)
		{
			if (ai.transform.position.z > player.transform.position.z)
			{
				playerCurrentPosition = 2;
			}
			else if (ai.transform.position.z <= player.transform.position.z)
			{
				playerCurrentPosition = 1;
			}
		}
		else 
		{
			finishedText();
		}

	}

	void finishedText() 
	{
		if (playerCurrentPosition == 1)
			finishedPositionText.text = "You Finished: 1st Place";
		else
			finishedPositionText.text = "You Finished: 2nd Place";
	}

	void currentPos() 
	{
		currentPosText.text = "Position: " + playerCurrentPosition + "/" + "2";
	}
}

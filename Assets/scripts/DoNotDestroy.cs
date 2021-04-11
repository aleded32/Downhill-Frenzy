using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour {

	public GameObject audio;
	public static DoNotDestroy instance;
	
	void Awake() 
	{
		if (instance)
			Destroy(audio);
		else if(!instance)
		{
			instance = this;
			DontDestroyOnLoad(audio);
		}
			
	}
}

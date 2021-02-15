using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class topBikeCollision : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "floor")
		{
			Debug.Log("hello");
			SceneManager.LoadScene("Level1");
		}

	}

	
}

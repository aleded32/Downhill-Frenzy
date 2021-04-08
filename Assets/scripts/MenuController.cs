using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {


	public void courseSelection() 
	{
		SceneManager.LoadScene("CourseSelection");
	}

	public void Quit()
	{
		Application.Quit();
	}

	public void Instructions()
	{
		SceneManager.LoadScene("Instructions");
	}

	public void start()
	{
		SceneManager.LoadScene("startMenu");
	}

	public void Level1()
	{
		SceneManager.LoadScene("Level1");
	}

	public void Level2()
	{
		SceneManager.LoadScene("Level2");
	}
}

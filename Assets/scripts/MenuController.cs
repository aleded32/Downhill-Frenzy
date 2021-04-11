using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {


	public void courseSelectionTime() 
	{
		SceneManager.LoadScene("CourseSelectionTime");
	}

	public void courseSelectionVs()
	{
		SceneManager.LoadScene("CourseSelectionVs");
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

	public void Level1Time()
	{
		SceneManager.LoadScene("Level1Time");
	}

	public void Level2Time()
	{
		SceneManager.LoadScene("Level2Time");
	}

	public void Level1Vs()
	{
		SceneManager.LoadScene("Level1Vs");
	}

	public void Level2Vs()
	{
		SceneManager.LoadScene("Level2Vs");
	}
}

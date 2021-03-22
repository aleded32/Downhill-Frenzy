using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bikeAIController : MonoBehaviour {

	public GameObject bike;

	public List<Vector3> positions;
	public List<Vector3> rotations;
	int i;
	bikeAIData data;

	void Start ()
	{
		positions = new List<Vector3>();
		rotations = new List<Vector3>();
		i = 0;
		if (SceneManager.GetActiveScene().name == "Level1")
		{
			data = SaveData.loadAI("level1AI.data");
		}
		else if (SceneManager.GetActiveScene().name == "Level2")
		{
			data = SaveData.loadAI("level2AI.data");
		}



	}

	public void saveData() 
	{
		if (SceneManager.GetActiveScene().name == "Level1")
		{
			SaveData.SaveAI(this, "Level1AI.data");
		}
		else if (SceneManager.GetActiveScene().name == "Level2")
		{
			SaveData.SaveAI(this, "Level2AI.data");
		}
	}

	public void LoadData(int i) 
	{
		

		
			
				positions.Add(new Vector3(data.positionX[i], data.positionY[i], data.positionZ[i]));

				rotations.Add(new Vector3(data.rotationX[i], data.rotationY[i], data.rotationZ[i]));
				
			
		
		
	}

	
	void FixedUpdate () 
	{

		if (i < data.positionX.Length) 
		{
			LoadData(i);
			i++;
		}
		
		
		moveAI();
		//positions.Add(bike.transform.position);
		//rotations.Add(bike.transform.rotation.eulerAngles);

		

		//transform.rotation = rotations[i] * Time.deltaTime;

		/*foreach (Vector3 pos in positions) 
		{
			transform.position = pos;
		}

		foreach (Vector3 rot in rotations) 
		{
			transform.rotation = Quaternion.Euler(rot);
		}*/
		
	}

	void moveAI() 
	{
		foreach (Vector3 pos in positions)
		{
			transform.position = Vector3.Lerp(transform.position, pos, Time.fixedDeltaTime/0.18f);
			
		}

		foreach (Vector3 rot in rotations)
		{
			transform.rotation = Quaternion.Lerp(transform.rotation ,Quaternion.Euler(rot), Time.fixedDeltaTime/0.18f);
			
		}
	}






}

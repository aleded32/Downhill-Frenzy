using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
		data = SaveData.loadAI();



	}

	public void saveData() 
	{
		SaveData.SaveAI(this);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveData {

	public static void SaveAI(bikeAIController bikeAI, string fileName) 
	{
		BinaryFormatter formatter = new BinaryFormatter();

		string path = Application.persistentDataPath + fileName;

		FileStream stream = new FileStream(path, FileMode.Create);

		bikeAIData data = new bikeAIData(bikeAI);

		formatter.Serialize(stream, data);

		stream.Close();

	}


	public static bikeAIData loadAI(string fileName) 
	{
		string path = Application.persistentDataPath + fileName;

		if (File.Exists(path))
		{
			BinaryFormatter formatter = new BinaryFormatter();

			FileStream stream = new FileStream(path, FileMode.Open);

			bikeAIData data = formatter.Deserialize(stream) as bikeAIData;

			stream.Close();

			return data;

		}
		else 
		{
			Debug.LogError("Save file not found");
			return null;
		}
	}


}

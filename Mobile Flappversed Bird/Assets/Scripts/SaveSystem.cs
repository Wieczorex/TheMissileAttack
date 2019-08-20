using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
	public static void SavePlayer(GameControl gameControl)
	{
		BinaryFormatter formatter = new BinaryFormatter();
		string path = Application.persistentDataPath + "/Player.fun";

		FileStream stream = new FileStream(path, FileMode.Create);

		PlayerData data = new PlayerData(gameControl);

		formatter.Serialize(stream, data);
		stream.Close();
	}

	public static PlayerData LoadPlayer()
	{
		string path = Application.persistentDataPath + "/Player.fun";
		if (File.Exists(path))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = new FileStream(path, FileMode.Open);

			PlayerData data = formatter.Deserialize(stream) as PlayerData;

			stream.Close();

			return data;
		}
		else
		{
			Debug.LogError("Save File Not Found in " + path);
			return null;
		}
	}
}

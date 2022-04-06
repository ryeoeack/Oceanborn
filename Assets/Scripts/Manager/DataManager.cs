using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public int money;
    public int playerLevel;
    public bool autoSaveEnabled;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        } else { Destroy(gameObject); }
        DontDestroyOnLoad(instance);
        FetchSave();
    }

    void FetchSave()
    {
        string path = Application.persistentDataPath + "/save/savdat.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            playerLevel = data.playerLevel;
            money = data.money;
            GameManager.instance.currentCityID = data.currentCityID;
        }
    }

    public void WriteToSave()
    {
        SaveData data = new SaveData();
        data.money = money;
        data.playerLevel = playerLevel;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/save/savdat.json", json);
    }

    IEnumerator AutoSaveRoutine()
    {
        while (autoSaveEnabled)
        {
            yield return new WaitForSeconds(60);
            WriteToSave();
        }

    }
}

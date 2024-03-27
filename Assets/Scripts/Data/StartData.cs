using UnityEngine;

public class StartData : MonoBehaviour
{
    public int _record;

    private void Start()
    {
        Load();
    }

    private void OnApplicationQuit()
    {
        Save();
    }

    private void OnDisable()
    {
        Save();
    }

    public void Load()
    {
        var data = SaveManager.Load<SaveData.GameData>(Constants.Data.SAVEKEY);
        
        _record = data.record;
        
        Debug.Log("Данные загружены");
    }

    public void Save()
    {
        SaveManager.Save(Constants.Data.SAVEKEY, GetSaveSnapshot());
        PlayerPrefs.Save();
        
        Debug.Log("Данные сохранены");
    }

    public SaveData.GameData GetSaveSnapshot()
    {
        var data = new SaveData.GameData()
        {
            record = _record
        };

        return data;
    }

}

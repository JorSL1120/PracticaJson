using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public string textJson;
    public Stats stats2;
    public string textToJson;

    void Start()
    {
        Stats stats = new Stats();
        textJson = JsonUtility.ToJson(stats);

        Debug.Log(textJson);

        NewStats();
    }

    void NewStats()
    {
        stats2 = JsonUtility.FromJson<Stats>(textToJson);
        Debug.Log(stats2);
    }
}

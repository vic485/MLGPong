using UnityEngine;

public class Disclaimer : MonoBehaviour
{
    void Awake()
    {
        if (PlayerPrefs.GetInt("Agreed") == 1)
        {
            Application.LoadLevel(Application.loadedLevel + 1);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayerPrefs.SetInt("Agreed", 1);
            Application.LoadLevel(Application.loadedLevel + 1);
        }
    }
}
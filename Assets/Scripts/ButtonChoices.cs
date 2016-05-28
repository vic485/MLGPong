using UnityEngine;

public class ButtonChoices : MonoBehaviour
{
    // Plays the multiplayer game
    public void Play()
    {
        Application.LoadLevel("MultiLevel");
        PlayerPrefs.SetInt("PlayedGame", 1);
    }

    // Plays the singleplayer game
    public void Play(int difficulty)
    {
        Application.LoadLevel("SingleLevel");
        PlayerPrefs.SetInt("Difficulty", difficulty);
        PlayerPrefs.SetInt("PlayedGame", 1);
    }

    // Quits the game
    public void Quit()
    {
        if (PlayerPrefs.GetInt("PlayedGame") == 1)
        {
            PlayerPrefs.SetInt("PlayedGame", 0);
            Application.LoadLevel("Quit");
        }
        else
            Application.Quit();
    }
}
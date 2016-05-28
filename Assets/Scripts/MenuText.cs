using UnityEngine;
using UnityEngine.UI;

public class MenuText : MonoBehaviour
{
    public Text text;   // The text object
    private string line = "null";   // the text to display

    void Awake()
    {
        // Chooses a random text to display
        int num = Random.Range(0, 21);
        switch (num)
        {
            case 0:
                line = "#rekt edition";
                break;
            case 1:
                line = "2v1 me bruhh!!!1";
                break;
            case 2:
                line = "Sample Text";
                break;
            case 3:
                line = "U wot m9?";
                break;
            case 4:
                line = "Do not play if you are scrub";
                break;
            case 5:
                line = "but if i? am kill... who, was, fone?";
                break;
            case 6:
                line = "lel wut?";
                break;
            case 7:
                line = "Subskrib 4 mor gamez";
                break;
            case 8:
                line = "a dingo 8 ur baby";
                break;
            case 9:
                line = "dew a barrul rowl";
                break;
            case 10:
                line = "bettur then stairfax";
                break;
            case 11:
                line = "MOM GET THE CAMERA!!!!1!";
                break;
            case 12:
                line = "gr8 m8, i r8 8/8";
                break;
            case 13:
                line = "GET NOSKOPEDD!!!!!";
                break;
            case 14:
                line = "360 no scope";
                break;
            case 15:
                line = "420 no scope";
                break;
            case 16:
                line = "420 blaze it";
                break;
            case 17:
                line = "gtg fast";
                break;
            case 18:
                line = "So much sweg";
                break;
            case 19:
                line = "Tomorrow's Forecast: Swegpocolypse";
                break;
            case 20:
                line = "FUCK YO GRAPES!";
                break;
            default:
                line = "WTF happened here...";
                break;
        }
        text.text = line;
    }

    // for testing and debug purposes, will be removed
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Awake();
        }
    }
}
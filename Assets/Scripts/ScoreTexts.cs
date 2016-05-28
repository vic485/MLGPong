using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreTexts : MonoBehaviour
{
    public Text[] texts;    // Objects to display text on
    private string text;    // the text to display
    private int d;  // which text object to use

    void Awake()
    {
        // Forces all text object to display nothing
        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].text = "";
        }
    }

    public void Display()
    {
        // Forces a null display for any texts that may still be active
        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].text = "";
        }

        // Choose a random text and object
        int t = Random.Range(0, 14);
        d = Random.Range(0, texts.Length);

        switch (t)
        {
            case 0:
                text = "ded";
                break;
            case 1:
                text = "ill figt u";
                break;
            case 2:
                text = "fight me irl feg";
                break;
            case 3:
                text = "#shrekt";
                break;
            case 4:
                text = "get shrekt m8";
                break;
            case 5:
                text = "wow";
                break;
            case 6:
                text = "am faze klan";
                break;
            case 7:
                text = "am kwikskope gad";
                break;
            case 8:
                text = "but wat if not kill?";
                break;
            case 9:
                text = "LOOMYNARTY CUNFIRM!!1!";
                break;
            case 10:
                text = "u fuking wot m8?";
                break;
            case 11:
                text = "u cheeky cunt";
                break;
            case 12:
                text = "Skrubskribe 4 moar killz";
                break;
            case 13:
                text = "nice shot m80";
                break;
            default:
                text = "Error - Random.Range is too high";
                break;
        }
        StartCoroutine(TextRun());
    }

    IEnumerator TextRun()
    {
        // Manages the flashing and duration for the text object chosen
        int repeat = Random.Range(4, 8);
        float flash;
        for (int i = 1; i <= repeat; i++)
        {
            flash = Random.Range(0.15f, 0.4f);
            yield return new WaitForSeconds(flash);
            texts[d].text = text;
            yield return new WaitForSeconds(flash);
            texts[d].text = "";
        }
    }
}
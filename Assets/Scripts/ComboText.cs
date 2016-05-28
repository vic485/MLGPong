using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ComboText : MonoBehaviour
{
    public Text comboText;  // The text object used for the display
    public AudioClip tripleClip;    // The sound clip used for triple combo
    public AudioClip womboClip;     // The sound clip used for wombo combo
    public GameObject WowObject;    // The Game Object for the WOW combo

    void Awake()
    {
        // Forces text to be blank
        comboText.text = "";
    }

    // Called with size of combo
    public void StartCombo(int combo)
    {
        // Turns of all currently active score sounds
        GameObject[] clone = GameObject.FindGameObjectsWithTag("ScoreSound");
        for (int i = 0; i < clone.Length; i++)
        {
            Destroy(clone[i]);
        }

        // Start a triple combo
        if (combo == 3)
        {
            GetComponent<AudioSource>().clip = tripleClip;
            GetComponent<AudioSource>().Play();
            StartCoroutine(Triple());
        }
            // Start a wombo combo
        else if (combo == 5)
        {
            GetComponent<AudioSource>().clip = womboClip;
            GetComponent<AudioSource>().Play();
            StartCoroutine(Wombo());
        }

        // Start Wow combo
        else if (combo == 10)
        {
            StartCoroutine(Wow());
        }
    }

    // Manages the display of the triple combo
    IEnumerator Triple()
    {
        comboText.text = "OH";
        yield return new WaitForSeconds(0.7f);
        comboText.text = "BABY";
        yield return new WaitForSeconds(0.8f);
        comboText.text = "A";
        yield return new WaitForSeconds(0.2f);
        comboText.text = "Triple!";
        yield return new WaitForSeconds(1.2f);
        comboText.text = "";
    }

    // Manages the display of the wombo combo
    IEnumerator Wombo()
    {
        comboText.text = "WOMBO";
        yield return new WaitForSeconds(0.7f);
        comboText.text = "COMBO!";
        yield return new WaitForSeconds(1.4f);
        comboText.text = "";
    }

    // Creates the object for the Wow combo
    IEnumerator Wow()
    {
        GameObject clone = (GameObject)Instantiate(WowObject, new Vector3(0, 0, 0), Quaternion.identity);
        yield return new WaitForSeconds(3.609783f); // Waits for the image to animate one time
        Destroy(clone);
    }
}
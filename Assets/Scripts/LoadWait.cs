using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadWait : MonoBehaviour
{
    public Text scrubText;  // The text objec

    public float textWait = 3f; // how long to wait before displaying the text
    public float nextWait = 1.5f;   // how long to wait after displaying

    IEnumerator Start()
    {
        scrubText.text = "";
        yield return new WaitForSeconds(textWait);
        scrubText.text = "THIS GAME IS AMAZING AND SHOULD NOT BE PLAYED BY SCRUBS!!!";
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(nextWait);
        Application.LoadLevel("MainMenu");
    }
}
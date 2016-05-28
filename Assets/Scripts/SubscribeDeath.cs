using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SubscribeDeath : MonoBehaviour
{
    public Text swagText;   // The text that scrolls on the screen
    private string previousText;    // copy of what the text was in the previous iteration
    private float textWait = 1.0f;  // how long to wait for the change in text
    public GameObject[] videos; // The videos played

    void Awake()
    {
        VideoStart();
        StartCoroutine(TextAdd());
        StartCoroutine(Kill());
    }

    void VideoStart()
    {
        // Play all the movies
        for (int i = 0; i < videos.Length; i++)
        {
            Renderer r = videos[i].GetComponent<Renderer>();
            MovieTexture movie = (MovieTexture)r.material.mainTexture;
            movie.Play();
        }
    }

    IEnumerator TextAdd()
    {
        // Scroll the text
        while (true)
        {
            previousText = swagText.text;
            yield return new WaitForSeconds(textWait);
            swagText.text = (previousText + "Swag ");
            textWait = textWait / 1.5f;
        }
    }

    IEnumerator Kill()
    {
        yield return new WaitForSeconds(6f);
        Application.LoadLevel("MainMenu");
    }
}
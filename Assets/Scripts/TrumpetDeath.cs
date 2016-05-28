using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TrumpetDeath : MonoBehaviour
{
    public GameObject explosion;
    public Text text1;
    public Text text2;

    void Awake()
    {
        text1.text = "";
        text2.text = "";
        Renderer r = GetComponent<Renderer>();
        MovieTexture movie = (MovieTexture)r.material.mainTexture;
        AudioSource a = GetComponent<AudioSource>();

        movie.Play();
        a.Play();
        StartCoroutine(Run());
        StartCoroutine(Kill());
    }

    IEnumerator Run()
    {
        yield return new WaitForSeconds(2f);
        text1.text = "Thnx 4 playin";
        yield return new WaitForSeconds(3.5f);
        text2.text = "tri agen, lel";
        Debug.Log("Explosion");
    }

    IEnumerator Kill()
    {
        yield return new WaitForSeconds(13f);
        Application.LoadLevel("MainMenu");
    }
}
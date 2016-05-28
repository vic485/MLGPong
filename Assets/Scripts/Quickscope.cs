using UnityEngine;
using System.Collections;

public class Quickscope : MonoBehaviour
{
    AudioSource audio;

    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    public void Play()
    {
        audio.Play();
    }

    public void Kill()
    {
        Destroy(gameObject);
    }
}
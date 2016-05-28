using UnityEngine;

public class ScoreSounds : MonoBehaviour
{
    public AudioClip[] sounds;  // The sounds that can be played
    bool soundStarted = false;  // Whether we have begun playing a sound
    AudioSource music;  // The object playing the background music

    void Awake()
    {
        // Assign the variable
        music = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();
        // Set the sound to play
        soundStarted = false;
        int num = Random.Range(0, sounds.Length);

        GetComponent<AudioSource>().clip = sounds[num];
        music.volume = 0.5f;    // Lower music volume
        GetComponent<AudioSource>().Play();
        soundStarted = true;
    }

    void Update()
    {
        if (soundStarted)
        {
            if (GetComponent<AudioSource>().isPlaying)
            {
                // If we are still playing sound do nothing
                return;
            }
            else
            {
                // If the sound is done playing restore the music volume, and destroy this
                Destroy(gameObject);
            }
        }
    }
}
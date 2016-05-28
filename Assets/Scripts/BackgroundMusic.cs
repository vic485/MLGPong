using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioClip[] myMusic;

    private int lastSongPlayed;

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("ScoreSound").Length <= 0)
            GetComponent<AudioSource>().volume = 1f;
        if (Input.GetKey(KeyCode.C))
            playRandomMusic();
        if (GetComponent<AudioSource>().isPlaying)
            return;
        playRandomMusic();
    }

    void playRandomMusic()
    {
        int songToPlay = Random.Range(0, myMusic.Length);
        if (lastSongPlayed != null && songToPlay == lastSongPlayed)
            return;
        GetComponent<AudioSource>().clip = myMusic[songToPlay];
        GetComponent<AudioSource>().Play();
        lastSongPlayed = songToPlay;
    }
}
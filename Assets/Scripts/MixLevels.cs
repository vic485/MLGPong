using UnityEngine;
using UnityEngine.Audio;

public class MixLevels : MonoBehaviour
{
    public AudioMixer masterMixer;  // The sound mixer

    // Set the sound effect level
    public void SetSfxLvl(float sfxLvl)
    {
        masterMixer.SetFloat("SFXVol", sfxLvl);
    }

    // Set the music level
    public void SetMusicLvl(float musicLvl)
    {
        masterMixer.SetFloat("MusicVol", musicLvl);
    }
}
using UnityEngine.Audio;
using UnityEngine;
using System;

public class SoundManager : MonoBehaviour
{
    public Sound[] Sounds;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        foreach(Sound s in Sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.Clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void Play (string name)
    {
        Sound s = Array.Find(Sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void DotScored()
    {
        FindObjectOfType<SoundManager>().Play("WinSound");
    }

    public void DotMissed()
    {
        FindObjectOfType<SoundManager>().Play("LoseSound");
    }
    public void LevelCleared()
    {
        FindObjectOfType<SoundManager>().Play("LevelClearedSound");
    }
}

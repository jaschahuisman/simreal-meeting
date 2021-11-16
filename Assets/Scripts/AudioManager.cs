using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    void Awake()
    {
        foreach (Sound s in sounds) 
        {
            s.source = gameObject.AddComponent<AudioSource>();  // Voegt de Audiosource toe.
            s.source.clip = s.clip;                                // linkt de clip met de volume variable in clip.
            s.source.volume = s.volume;                         // linkt de audio volume met de volume variable in sound.
        }
    }

    // Update is called once per frame
    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}

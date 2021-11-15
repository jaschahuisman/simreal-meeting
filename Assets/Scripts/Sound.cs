using UnityEngine.Audio;
using UnityEngine;


[System.Serializable]
public class Sound
{
    public string name;       // maakt de string attribute in de SoundManager;
    public AudioClip clip;      // maakt de AudioClip attribute in de SoundManager;

                                 // Maakt een volume slider in de SoundManager;
    [Range(0f, 1f)]
    public float volume;

                                // Maakt een verborgen AudioSource voor elke sound in de AudioManager
    [HideInInspector]
    public AudioSource source;
}

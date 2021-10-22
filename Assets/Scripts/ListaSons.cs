using UnityEngine.Audio;
using UnityEngine;


[System.Serializable]
public class ListaSons
{
    public string Nome;
    public AudioSource Source;
    public AudioClip Clipe;

    [Range(0f, 1f)]
    public float Volume;
    [Range(1f, 3f)]
    public float Pitch;

}

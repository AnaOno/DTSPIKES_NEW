using UnityEngine.Audio;
using System;
using UnityEngine;

public class Som : MonoBehaviour
{
    public ListaSons[] Sons;

    void Awake()
    {
        foreach(ListaSons Som in Sons)
        {
           Som.Source = gameObject.AddComponent<AudioSource>();
           Som.Source.clip = Som.Clipe;
           Som.Source.volume = Som.Volume;
           Som.Source.pitch = Som.Pitch;
        }
    }
        
    public void Play (string Nome)
    {
        ListaSons Som = Array.Find(Sons, Som => Som.Nome == Nome);
        Som.Source.Play();
    }
}

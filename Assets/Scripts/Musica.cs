using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{
    private static Musica musica;
    void Awake()
    {
        if (musica == null)
        {
            musica = this;
            DontDestroyOnLoad(musica);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
}

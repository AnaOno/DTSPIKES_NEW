using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private GameObject Pontua;
    public float TempoR = 0.1f;
        
    void Start()
    {
        Pontua = GameObject.FindGameObjectWithTag("Pontuacao");
    }

    
    private void Update()
    {
       Random.Range(0, 2);
    }
}

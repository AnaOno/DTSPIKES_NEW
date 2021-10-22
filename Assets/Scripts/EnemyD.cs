using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyD : MonoBehaviour
{

    void Start()
    {
        transform.position = new Vector2(2, Random.Range(-3, 3));
    }

    void Update()
    {
        
    }
}

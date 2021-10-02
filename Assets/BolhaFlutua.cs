using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolhaFlutua : MonoBehaviour
{
    private Rigidbody2D _myRigidbody;
    [SerializeField] private Vector2 bolhaForce;
    //atributo, modificacoes que pode-se empregar a uma classe ou variavel

    void Start()
    {
       _myRigidbody = GetComponent<Rigidbody2D>();
        //generic, retorna qualquer coisa na classe component
    }

    public void Flutua()
    {
       _myRigidbody.velocity = Vector2.zero;
       _myRigidbody.AddForce(bolhaForce, ForceMode2D.Impulse);

    }

    private void Update()
    {
       //nao usar input dentro do update
       //input atraves de eventos

    }
}

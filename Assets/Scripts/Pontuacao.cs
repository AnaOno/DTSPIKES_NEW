using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

  public class Pontuacao : MonoBehaviour
{
    public Text Score;
    public int Soma;
    public float TempoR;
    public GameObject Ponto;

    void Start()
    {
        Soma = 0;
        Ponto = GameObject.Find("Pontuacao");
        Ponto.transform.position = new Vector2(Random.Range(-2, 2), Random.Range(4, -5));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.CompareTag("Pontuacao") == true)
        {
            Soma = Soma + 1;
            Spawnar();
            FindObjectOfType<Som>().Play("PontoPlayer");
        }
    }

    public void Spawnar()
    {
        Ponto.transform.position = new Vector2(Random.Range(-2, 2), Random.Range(3, -3));
    }


    private void Update()
    {
        Score.text = Soma.ToString();
    }
}

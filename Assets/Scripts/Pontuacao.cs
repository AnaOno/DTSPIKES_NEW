using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

  public class Pontuacao : MonoBehaviour
{
    public Text Score;
    private int Soma;

    void Start()
    {
        Soma = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pontuacao") == true)
        {
            Soma = Soma + 1;
            Destroy(collision.gameObject);
        }
    }
    private void Update()
    {
        Score.text = Soma.ToString();
    }
}

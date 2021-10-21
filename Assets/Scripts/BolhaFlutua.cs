using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BolhaFlutua : MonoBehaviour
{
    private Rigidbody2D _myRigidbody;
    [SerializeField] private Vector2 bolhaForceInicio;
    [SerializeField] private Vector2 bolhaForce;
    [SerializeField] private Vector2 bolhaForceInvert;
    public bool Flutuar;
    public bool PowerUp;
    public bool B = true;


    void Start()
    {
        _myRigidbody = GetComponent<Rigidbody2D>();
        _myRigidbody.IsSleeping();
    }

    public void Inicio()
    {
        if (B)
        {
            _myRigidbody.WakeUp();
            B = false;
            _myRigidbody.velocity = Vector2.zero;
            _myRigidbody.AddForce(bolhaForceInicio, ForceMode2D.Impulse);
        }
        
    }

    public void Flutua()
    {
        if (Flutuar)
        {
            _myRigidbody.velocity = Vector2.zero;
            _myRigidbody.AddForce(bolhaForce, ForceMode2D.Impulse);
        }
        else
        {
            _myRigidbody.velocity = Vector2.zero;
            _myRigidbody.AddForce(bolhaForceInvert, ForceMode2D.Impulse);
        }
    }
       
    

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ParedeE")
        {
            Flutuar = true;
        }
        if (collision.gameObject.tag == "ParedeD")
        {
            Flutuar = false;
        }
        if (collision.gameObject.tag == "CollidFixo")
        {
            if (PowerUp == true)
            {
                PowerUp = false;
            }
            else
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
            }
        }
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PowerUp")
        {
            PowerUp = true;
        }
    }
}

      


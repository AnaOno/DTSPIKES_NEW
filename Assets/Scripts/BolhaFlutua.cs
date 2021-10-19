using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;

public class BolhaFlutua : MonoBehaviour
{
    private Rigidbody2D _myRigidbody;
    [SerializeField] private Vector2 bolhaForce;

    void Start()
    {
        _myRigidbody = GetComponent<Rigidbody2D>();

    }

    public void Flutua()
    {
        _myRigidbody.velocity = Vector2.zero;
        _myRigidbody.AddForce(bolhaForce, ForceMode2D.Impulse);

    }
    public void Inverte()
    {
        void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Paredes")
            {
                bolhaForce.x *= 1;
            }
    }
}

    
    public void OnCollisionEnter2D(Collision2D collision)
    {
     
        if (collision.gameObject.tag == "CollidFixo")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }
        
    }

     
}

      


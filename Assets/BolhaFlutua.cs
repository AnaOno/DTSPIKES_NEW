using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolhaFlutua : MonoBehaviour
{
    private Rigidbody2D _myRigidbody;
    [SerializeField] private Vector2 bolhaForce;
   // private bool morreu;
    

    void Start()
    {
       _myRigidbody = GetComponent<Rigidbody2D>();
        
    }

    public void Flutua()
    {
        //if (morreu)
       // {
           
       // }

       _myRigidbody.velocity = Vector2.zero;
       _myRigidbody.AddForce(bolhaForce, ForceMode2D.Impulse);

    }

    //private void OnCollisionEnter2D(Collision2D other)
   // {
    //   if(other.gameObject.CompareTag("Death"))
    //    {
    //        Death();
     //   }
  //  }
}

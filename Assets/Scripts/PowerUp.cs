using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    void Start()
    {
        transform.position = new Vector2(Random.Range(-2, 2), 7);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Limite") == true)
        {
            StartCoroutine(Delay());
            transform.position = new Vector3(Random.Range(-2, 2), 6, 0);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Delay());
            transform.position = new Vector3(Random.Range(-2, 2), 6, 0);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
    
    public IEnumerator Delay()
    {
        yield return new WaitForSeconds(2f);
    }
   
}

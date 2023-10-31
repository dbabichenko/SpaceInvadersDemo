using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    public float speed = 0.1f;
    
    void Update()
    {
        Vector2 newPos = new Vector2(
            gameObject.transform.position.x,
            gameObject.transform.position.y + speed
            ) ;
        gameObject.transform.position = newPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Boundary")
        {
            // Destroy self
            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "Alien")
        {
            // Destroy alien
            // collision.gameObject.GetComponent<AudioSource>().Play();
            Destroy(collision.gameObject);
            // Destroy self
            Destroy(gameObject);

        }
    }
}

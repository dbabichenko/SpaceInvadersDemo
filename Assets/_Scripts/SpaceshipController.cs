using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    public float speed = 0.1f;
    public GameObject bullet;

    void Start()
    {
        
    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector2 newPos = new Vector2(
                gameObject.transform.position.x - speed,
                gameObject.transform.position.y
                );
            gameObject.transform.position = newPos;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector2 newPos = new Vector2(
                gameObject.transform.position.x + speed,
                gameObject.transform.position.y
                );
            gameObject.transform.position = newPos;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
        }

    }
}

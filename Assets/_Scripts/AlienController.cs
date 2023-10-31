using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienController : MonoBehaviour
{

    public int speed = 1;
    private float timePassed = 0f;
    private int direction = 1;
    // Update is called once per frame
    void Update()
    {
        Vector2 pos = new Vector2(gameObject.transform.position.x + speed * direction * Time.deltaTime,
            gameObject.transform.position.y);
        gameObject.transform.position = pos;
        timePassed += Time.deltaTime;

      if(timePassed >= 5)
        {
            direction = direction * -1;
            timePassed = 0;
        }
    }
}

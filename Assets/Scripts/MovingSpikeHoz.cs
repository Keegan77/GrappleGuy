using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSpikeHoz : MonoBehaviour
{
    bool movingLeft = true;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (movingLeft)
        {
            transform.Translate(Vector2.left * Time.deltaTime * 7);

        }
        else if (!movingLeft)
        {
            transform.Translate(Vector2.right * Time.deltaTime * 7);
        }
        if (transform.position.x < -14)
        {
            //Destroy(gameObject);
        }
        if (transform.position.x > 14)
        {
            //Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("StopSpikes"))
        {
            Destroy(gameObject);
        }
    }
}


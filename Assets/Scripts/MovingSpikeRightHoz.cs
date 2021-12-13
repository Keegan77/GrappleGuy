using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSpikeRightHoz : MonoBehaviour
{
    // Start is called before the first frame update
    public bool movingLeft;
    void Start()
    {
        movingLeft = false;
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
           // Destroy(gameObject);
        }
        if (transform.position.x > 14)
        {
            //Destroy(gameObject);
        }
    }
}
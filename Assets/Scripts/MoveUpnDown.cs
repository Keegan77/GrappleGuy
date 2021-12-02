using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpnDown : MonoBehaviour
{
    // Start is called before the first frame update
    public bool movingDown = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movingDown)
        {
            transform.Translate(0, -.005f, 0);
        } else if (!movingDown)
        {
            transform.Translate(0, .005f, 0);
        }
        if (transform.position.y < 3)
        {
            movingDown = false;
        }
        if (transform.position.y > 10.5f)
        {
            movingDown = true;
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("yo");
        if (other.CompareTag("MoveUp"))
        {
            movingDown = false;
            Debug.Log("yo");
        }
        if (other.CompareTag("MoveDown"))
        {
            movingDown = true;
            Debug.Log("yo");
        }
    }
}

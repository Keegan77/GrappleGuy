using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpnDown : MonoBehaviour
{
    // Start is called before the first frame update
    public bool movingDown = true;
    public float yUp;
    public float yDown;
    float platformspeed = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movingDown)
        {
            transform.Translate(new Vector3(0, -platformspeed, 0) * Time.deltaTime);
        } else if (!movingDown)
        {
            transform.Translate(new Vector3(0, platformspeed, 0) * Time.deltaTime);
        }
        if (transform.position.y < yUp /*3*/)
        {
            movingDown = false;
        }
        if (transform.position.y > yDown/*10.5f*/)
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

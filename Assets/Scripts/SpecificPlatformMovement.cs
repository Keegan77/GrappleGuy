using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecificPlatformMovement : MonoBehaviour
{
    public bool steppedOn;

    float time = 1;
    public float movementCap;
    public GameObject player;
    
    void Start()
    {

    }

    void Update()
    {
        if (steppedOn)
        {
            time -= Time.deltaTime;
            if (time < 0)
            {
                transform.Translate(new Vector3(0, -2, 0) * Time.deltaTime);

                if (transform.position.x > movementCap)
                {
                    Destroy(gameObject);
                }

            }

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            steppedOn = true;

        }
    }

}

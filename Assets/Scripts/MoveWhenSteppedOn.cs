using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWhenSteppedOn : MonoBehaviour
{
    public bool steppedOn;
    float time = 1;
    public float movementCap;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (steppedOn)
        {
            time -= Time.deltaTime;
            if (time < 0)
            {
                if (transform.position.y < movementCap)
                {
                    transform.Translate(new Vector3(2, 0, 0) * Time.deltaTime);
                }
                
            }
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Tag Detected");
            steppedOn = true;
        }
    }
}

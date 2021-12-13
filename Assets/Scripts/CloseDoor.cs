using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    public MoveWhenSteppedOn MovePlatform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MovePlatform.steppedOn && transform.position.y > 7.7836)
        {
            transform.Translate(new Vector3(0, -3, 0) * Time.deltaTime);
        }
    }
}

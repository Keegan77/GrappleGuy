using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDoorLevel3 : MonoBehaviour
{
    public PlayerController playervars;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playervars.doorTriggerStepped == true)
        {
            transform.Translate(new Vector3(0, -3.5f, 0) * Time.deltaTime);
        }
    }
}

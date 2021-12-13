using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRightLvl3 : MonoBehaviour
{
    public float startingTime;
    float currentTime;
    public GameObject spikes;
    public PlayerController playerVars;
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerVars.doorTriggerStepped == true)
        {
            currentTime -= Time.deltaTime;
            if (currentTime < 0)
            {
                Instantiate(spikes, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
                currentTime = startingTime;
            }
        }
    }
}

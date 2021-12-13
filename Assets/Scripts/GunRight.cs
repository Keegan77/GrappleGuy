using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRight : MonoBehaviour
{
    public float startingTime;
    float currentTime;
    public GameObject spikes;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime < 0)
        {
            Instantiate(spikes, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
            currentTime = startingTime;
        }

    }
}

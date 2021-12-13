using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float Timer;
    public bool levelClear = false;
    public Text timerText;
    public Text endText;
    public Text exit;
    public Text youDied;
    public Text restart;
    GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Timer = 0;
    }


    void Update()
    {
        if (player == null && !levelClear)
        {
            youDied.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(0);
            }
        }
        if (!levelClear)
        {
            Timer += Time.deltaTime;
        }
        if (levelClear)
        {
            endText.gameObject.SetActive(true);
            exit.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(0);
            }
            endText.text = $"You finished\nwith a time of {Timer.ToString("0.00")}!";
        }

        timerText.text = Timer.ToString("0.00");
        /*
        if (player != null && !levelClear && Input.GetKeyDown(KeyCode.Escape))
        {
         // start of the pause menu script, probably coming back to this later
        }
        */

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    float currentTime = .1f;

    public Text gameName;
    public Text pressEnter;
    public Text levelSelect;
    public Text oneTwoThree;
    public GameObject[] textSelections;
    bool onTitleScreen = true;
    bool menu = false;
    int mapCount = 2;
    int currentSelection = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Return) && onTitleScreen)
        {
            gameName.gameObject.SetActive(false);
            pressEnter.gameObject.SetActive(false);
            menu = true;
            onTitleScreen = false;
        }
        if (!onTitleScreen && menu)
        {
            currentTime -= Time.deltaTime;
            levelSelect.gameObject.SetActive(true);
            oneTwoThree.gameObject.SetActive(true);


            switch (currentSelection)
            {
                case 0:
                    textSelections[0].SetActive(true);
                    textSelections[1].SetActive(false);
                    textSelections[2].SetActive(false);
                    break;
                case 1:
                    textSelections[0].SetActive(false);
                    textSelections[1].SetActive(true);
                    textSelections[2].SetActive(false);
                    break;
                case 2:
                    textSelections[0].SetActive(false);
                    textSelections[1].SetActive(false);
                    textSelections[2].SetActive(true);
                    break;
            }
            Debug.Log(currentSelection);
            if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                currentSelection++;
                
            }
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                currentSelection--;
            }
            if (currentSelection < 0)
            {
                currentSelection = 0;
            }
            else if (currentSelection > mapCount)
            {
                currentSelection = mapCount;
            }
            if (currentTime < 0)
            {
                if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Mouse0))
                {
                    SceneManager.LoadScene(currentSelection + 1);
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {

                //make the menu/buttons appear 
                GetComponent<Canvas>().enabled = true;
                //pause the game
                Time.timeScale = 0;
            }
            else if (Time.timeScale == 0)

            {
                Resume();

            }


        }
    }
    public void Resume()
    {
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Application.Quit");
    }


}

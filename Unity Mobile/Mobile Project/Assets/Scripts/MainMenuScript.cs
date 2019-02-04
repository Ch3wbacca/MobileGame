using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void Easy()
    {
        SceneManager.LoadScene("Easy");
    }

    public void Normal()
    {
        SceneManager.LoadScene("Medium");
    }

    public void Hard()
    {
        SceneManager.LoadScene("Hard");
    }

    public void Quit()
    {
        Application.Quit();
    }
}

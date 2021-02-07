using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public void ButtonPlay()
    {
        SceneManager.LoadScene(1); 
    }

    public void ButtonCredits()
    {
        SceneManager.LoadScene(2);
    }

    public void ButtonQuit()
    {
        Application.Quit();
    }

}

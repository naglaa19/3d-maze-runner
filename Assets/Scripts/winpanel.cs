using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winpanel : MonoBehaviour
{
    public void mainmenue()
    {
        SceneManager.LoadScene("start");
    }
    public void quit()
    {
        Application.Quit();
    }
    public void next()
    {
        SceneManager.LoadScene("secondLevel");
    }
}

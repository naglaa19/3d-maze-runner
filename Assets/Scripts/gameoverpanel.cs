using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameoverpanel : MonoBehaviour
{
    public void restartlevel1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void mainmenue()
    {
        SceneManager.LoadScene("start");
    }
    public void restartlevel2()
    {
        SceneManager.LoadScene("secondLevel");
    }
}

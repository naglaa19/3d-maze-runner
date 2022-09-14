using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class counterLV2 : MonoBehaviour
{
    int countstartval = 45;
    public Text timerUI;
    // Start is called before the first frame update
    void Start()
    {
        timer();
    }

    void timer()
    {
        if (countstartval > 0)
        {
            timerUI.text = "Timer : " + countstartval;
            countstartval--;
            Invoke("timer", 1.0f);

        }
        else
        {
            timerUI.text = "";

            SceneManager.LoadScene("gameover2");
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class counter : MonoBehaviour
{
    int countstartval = 60;
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

            SceneManager.LoadScene("gameOver");
        }


    }
    // Update is called once per frame
    void Update()
    {

    }
}

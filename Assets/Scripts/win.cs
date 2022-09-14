using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class win : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "winLine1")
        {
            SceneManager.LoadScene("win");
        }
        if (other.gameObject.tag == "winLine2")
        {
            SceneManager.LoadScene("endgame");
        }

    }
}
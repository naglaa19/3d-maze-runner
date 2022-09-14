using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeControl : MonoBehaviour
{

    [SerializeField] Slider slider;

    public void changeVolume()
    {
        AudioListener.volume = slider.value;

    }
}

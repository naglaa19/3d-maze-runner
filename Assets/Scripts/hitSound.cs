using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitSound : MonoBehaviour
{
    public AudioSource hit;
    // Start is called before the first frame update
    void Start()
    {
        hit = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "block")
        {
            hit.Play();
        }
    }
}

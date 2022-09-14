using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    [SerializeField]
    private Transform playerTrans;
    [SerializeField]
    private Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = playerTrans.position + offset;
    }
}

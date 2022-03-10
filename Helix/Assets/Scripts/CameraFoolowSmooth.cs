using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFoolowSmooth : MonoBehaviour
{
    public Transform ball;
    Vector3 offset;
    public float smooth;
    void Start()
    {
        offset = transform.position - ball.position;
    }

    
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position,offset+ball.position,smooth);
        transform.position = newPos;
    }
}

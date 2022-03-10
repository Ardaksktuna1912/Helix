using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCylinderMouse : MonoBehaviour
{
    public float RotateSpeed;
    private float _MoveX;
   

    // Update is called once per frame
    void Update()
    {
        _MoveX = Input.GetAxis("Mouse X");
        if (Input.GetMouseButton(0))
        {
            transform.Rotate (0f,_MoveX*RotateSpeed*Time.deltaTime,0f);
        }
    }
}

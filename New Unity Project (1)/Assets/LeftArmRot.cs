using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.EventSystems;


public class LeftArmRot : MonoBehaviour
{
    public GameObject leftArm;
    float rotSpeed = 1000;

    void Start()
    {
        leftArm = transform.parent.gameObject;
    }
    
    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        leftArm.transform.Rotate(Vector3.up, rotX);
        leftArm.transform.Rotate(Vector3.right, rotY);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            leftArm.transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * Time.deltaTime * rotSpeed);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class RightArmRot : MonoBehaviour
{
    public GameObject neck;
    float rotSpeed = 1000;

    void Start()
    {
        neck = transform.parent.gameObject;
    }


    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        neck.transform.Rotate(Vector3.up, -rotX);
        neck.transform.Rotate(Vector3.right, -rotY);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
        neck.transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * Time.deltaTime * rotSpeed);
        }
    }
}
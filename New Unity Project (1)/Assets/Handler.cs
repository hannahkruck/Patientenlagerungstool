using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.EventSystems;

// Detects clicks from the mouse and prints a message
// depending on the click detected.

public class Handler : MonoBehaviour
{
    float rotSpeed = 1000;

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotX);
        transform.Rotate(Vector3.right, -rotY);
    }

    void Update()
    {

        /*if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log(hit.transform.gameObject.name);
            }
        }*/

        if ( Input.GetMouseButtonDown(0)){ // << use Get$$anonymous$$ouseButton ins$$anonymous$$d of Get$$anonymous$$ouseButtonDown
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if ( Physics.Raycast (ray,out hit,100.0f)) {
                Debug.Log("You selected the " + hit.transform.name); 
                hit.transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * Time.deltaTime * rotSpeed);// << declare public speed and set it in inspector
            }
         }
    }
    /*void Start()
    {
        control = GameObject.Find("GameControl").GetComponent<GameControlScript>();
    }// end start
    void OnMouseUp()
    {
        control.DoSomethingToClicked(this.transform.GameObject);
    }//end OnMouseUp*/
    }

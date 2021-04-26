 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.EventSystems;
 
 /*public class Modell : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
 {
     public float rotationSpeed;
     public float rotationDamping;
 
     private float _rotationVelocity;
     private bool _dragged;
 
     public void OnBeginDrag(PointerEventData eventData)
     {
         _dragged = true;
     }
 
     public void OnDrag(PointerEventData eventData)
     {
         _rotationVelocity = eventData.delta.x * rotationSpeed;
         transform.Rotate(Vector3.back, -_rotationVelocity, Space.Self);
     }
 
     public void OnEndDrag(PointerEventData eventData)
     {
         _dragged = false;
     }
 
     private void Update()
     {
         if( !_dragged && !Mathf.Approximately( _rotationVelocity, 0 ) )
         {
             float deltaVelocity = Mathf.Min(
                 Mathf.Sign(_rotationVelocity) * Time.deltaTime * rotationDamping,
                 Mathf.Sign(_rotationVelocity) * _rotationVelocity
             );
             _rotationVelocity -= deltaVelocity;
             transform.Rotate(Vector3.back, -_rotationVelocity, Space.Self);
         }
     }
 }*/
  /*public class Modell : MonoBehaviour 
 {
     
     private float _sensitivity;
     private Vector3 _mouseReference;
     private Vector3 _mouseOffset;
     private Vector3 _rotation;
     private bool _isRotating;
     
     void Start ()
     {
         _sensitivity = 0.4f;
         _rotation = Vector3.zero;
     }
     
     void Update(){
         if(_isRotating)
         {
             // offset
             _mouseOffset = (Input.mousePosition - _mouseReference);
             // apply rotation
             //_rotation.y = -(_mouseOffset.x + _mouseOffset.y) * _sensitivity;
             _rotation.y = -(_mouseOffset.x) * _sensitivity;
             _rotation.x = -(_mouseOffset.y) * _sensitivity;
             // rotate
             //transform.Rotate(_rotation);
             transform.eulerAngles += _rotation;
             // store mouse
             _mouseReference = Input.mousePosition;
         }
 }
     
     void OnMouseDown()
     {
         // rotating flag
         _isRotating = true;
         
         // store mouse
         _mouseReference = Input.mousePosition;
     }
     
     void OnMouseUp()
     {
         // rotating flag
         _isRotating = false;
     }
     
 }*/
 public class Modell : MonoBehaviour
{
    float rotSpeed = 1000;

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotX);
        transform.Rotate(Vector3.right, rotY);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * Time.deltaTime * rotSpeed);
        }
    }
}
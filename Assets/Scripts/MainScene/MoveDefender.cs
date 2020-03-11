using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDefender : MonoBehaviour
{
    [SerializeField] private float _speedRotation;
   

    
    void Update()
    {
        RotatDefender();   
    }

    private void RotatDefender()
    {
        Vector2 mousRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.DrawRay(transform.position, mousRay);
        Debug.Log(mousRay);
        transform.rotation = Quaternion.LookRotation(transform.position, mousRay);

}
}

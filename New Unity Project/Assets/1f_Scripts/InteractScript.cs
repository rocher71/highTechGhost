﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class InteractScript : MonoBehaviour 
{

    public float interactDiastance = 5f; 
    void Update() 
    { 
        if (Input.GetMouseButton(0)) 
        { 
            Ray ray = new Ray(transform.position, transform.forward); 
            RaycastHit hit; 
            if (Physics.Raycast(ray, out hit, interactDiastance))
            {
                if (hit.collider.CompareTag("Door")) 
                {
                    hit.collider.transform.parent.GetComponent<DoorScript>().ChangeDoorState(); 
                }
            } 
        } 
    }
}


﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
   
   public float speed;




    void Update()
    {
        Lookatmouse();
    }

    void Lookatmouse(){
        Plane playerplane = new Plane(Vector3.up,transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitdist;

        if(playerplane.Raycast(ray, out hitdist)){
            Vector3 targetpoint = ray.GetPoint(hitdist);
            Quaternion targetrotation = Quaternion.LookRotation(targetpoint-transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation,targetrotation,speed*Time.deltaTime);
        }
    }
    
    
}

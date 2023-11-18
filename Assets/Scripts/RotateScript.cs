using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public Transform target;
    public float speed;

    
    void Update()
    {
        transform.RotateAround(target.transform.position,target.transform.up,speed*Time.deltaTime);
    }
}

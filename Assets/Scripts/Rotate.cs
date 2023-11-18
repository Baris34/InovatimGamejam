using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 vec3;

    void Update()
    {
        transform.Rotate(vec3);
    }
}

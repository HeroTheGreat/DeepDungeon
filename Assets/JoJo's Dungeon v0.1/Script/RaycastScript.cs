using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    public BoxCollider Enemy1, Enemy2, Enemy3;
    public void Start()
    {
      
    }
    void Update()
    {
        Ray ray = new Ray();
        Debug.DrawRay(ray.origin, ray.direction, Color.cyan);
    }
}

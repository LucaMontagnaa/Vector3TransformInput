using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public float movementSpeed;
    public Vector3 movementVector;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
          transform.position += new Vector3(movementSpeed,0,0);
        }
    }
}

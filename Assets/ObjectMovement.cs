using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour


{
    public GameObject myCube;
    public Vector3 movementVector;
    
    void Start()
    {
      myCube.transform.position += movementVector;
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs (myCube.transform.position.x) < 8)
        {
            myCube.transform.position += movementVector;
        }
      
    }
}


 

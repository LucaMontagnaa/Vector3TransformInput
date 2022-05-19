using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPosition : MonoBehaviour
{

    public Vector3 newPosition;
    public GameObject mycube;
    void Start()
    {
        mycube.transform.position = newPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

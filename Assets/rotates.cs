using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotates : MonoBehaviour
{
    [SerializeField] float yRotation = 1f;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0f, 0f, yRotation * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vid : MonoBehaviour
{
    public GameObject target;
    Vector3 offset;
    
    void Start()
    {
        offset = new Vector3(0,1,0);
        
    }
    
    
    void Update()
    {
        transform.position = target.transform.position + offset;
        
    }
}

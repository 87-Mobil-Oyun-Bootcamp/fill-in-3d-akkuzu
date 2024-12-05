using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAreaController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "BlackCube")
        {
            Destroy(other.gameObject);          
            Debug.Log("2");           
            
        }
    }

    
}

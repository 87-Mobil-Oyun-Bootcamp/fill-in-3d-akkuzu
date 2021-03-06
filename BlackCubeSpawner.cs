using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCubeSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject blackcube;
 

    void Start()
    {
        for (int i = 0; i < 250; i++)
        {
            GameObject cube = Instantiate(blackcube, transform.position, Quaternion.identity);
            //cube.transform.position = new Vector3(1f, 1f, 1f);
            cube.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            
        }


    }

    
}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public void CubeMeshRendererController()
    {
        GameObject Cube = GameObject.FindGameObjectWithTag("SpriteCube");
        GetComponent<MeshRenderer>().enabled = true;
    }
    
}

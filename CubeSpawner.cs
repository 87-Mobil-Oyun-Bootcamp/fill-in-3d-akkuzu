using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [Space]
    [SerializeField]
    private Sprite sprite;

    [Space]
    [SerializeField]
    private GameObject cube;

    [Space]
    [SerializeField]
    private float offset = 0.1f;

    [SerializeField]
    float size = .1f;

    Vector3 cubePos = Vector3.zero;

    private void Awake()
    {
        CreateCubesFromImage(sprite.texture);
    }

    void CreateCubesFromImage(Texture2D image)
    {
        for (int x = 0; x < image.width; x++)
        {
            for (int y = 0; y < image.height; y++)
            {
                Color color = image.GetPixel(x, y);

                if (color.a == 0)
                {
                    continue;
                }

                cubePos = new Vector3(size * (x - (image.width * .5f)), size * .5f, size * (y - (image.height * .5f)));
                GameObject cubeObj = Instantiate(cube, transform);
                cubeObj.transform.localPosition = cubePos;
                cubeObj.GetComponent<Renderer>().material.color = color;
                cubeObj.transform.localScale = Vector3.one * size;
                    
            }
        }
    }
}       

   
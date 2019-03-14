using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class brickPlacement : MonoBehaviour
{
    public Transform prefab;
    void Start()
    {
        for (int i = -30; i < 40; i+=10)
        {
            for (int j = -30; j < 50; j += 10) 
            {
                Instantiate(prefab, new Vector3(i * 2.17F, 5, j * 2.13F-10), Quaternion.identity);
            }
        }
    }
}

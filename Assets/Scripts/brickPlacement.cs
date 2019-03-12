using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class brickPlacement : MonoBehaviour
{
    public Transform prefab;
    void Start()
    {
        for (int i = 0; i < 100; i+=10)
        {
            Instantiate(prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }
    }
}

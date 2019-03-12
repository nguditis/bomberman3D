using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb1 : MonoBehaviour
{
    AudioSource myAudio;
    public float speed = 3f;
    Vector3 temp;
    float counterTime;
    void Update()
    {
        counterTime = counterTime + Time.deltaTime;
        if (((int)counterTime) % 2 == 0)
        {
            Grow();
        }
        else 
        {
            Shrink();
        }
    }
    void Shrink()
    {
        temp = transform.localScale;
        temp.x = temp.x - Time.deltaTime;
        transform.localScale = temp;
    }
    void Grow()
    {
        temp = transform.localScale;
        temp.x = temp.x + Time.deltaTime;
        transform.localScale = temp;      
    }
    
}

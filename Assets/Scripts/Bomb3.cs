using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb3 : MonoBehaviour
{
    public float speed = 5f;
    Vector3 temp;
    float counterTime;
    void Update()
    {
        counterTime += Time.deltaTime;

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
        temp.x -= Time.deltaTime;
        transform.localScale = temp;
    }
    void Grow()
    {
        temp = transform.localScale;
        temp.x += Time.deltaTime;
        transform.localScale = temp;
    }

}

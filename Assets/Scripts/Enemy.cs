using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    Vector3 pointA;
    Vector3 pointB;
    // Start is called before the first frame update
    void Start()
    {
        pointA = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        pointB = new Vector3(transform.position.x , transform.position.y, transform.position.z - 10);


    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}

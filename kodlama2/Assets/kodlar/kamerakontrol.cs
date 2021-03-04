using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamerakontrol : MonoBehaviour
{
    public GameObject top;
    Vector3 aradakimesafe;
    void Start()
    {
        aradakimesafe = transform.position - top.transform.position;
    }


    void Update()
    {

        transform.position = top.transform.position + aradakimesafe;

    }
}

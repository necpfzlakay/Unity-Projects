using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermi : MonoBehaviour
{

    Rigidbody fizik;
    public float hizz;


    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.velocity = transform.forward*hizz;
    }
    

}

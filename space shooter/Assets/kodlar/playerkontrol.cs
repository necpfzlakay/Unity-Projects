using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerkontrol : MonoBehaviour
{

    Rigidbody fizik;
    float horizontal = 0;
    float vertical = 0;
    Vector3 vec;
    public float karakterhız;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float egim;
    float ateszamanı=0;
    public float Gecensure=0;
    public GameObject kursun;
    public Transform kursunCıkıs;

    void Start()
    {

        fizik = GetComponent<Rigidbody>();
    }
    /// <summary>
    /// ///////////////////////
    /// </summary>
    /// 
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time>ateszamanı)
        {
            ateszamanı = Time.time + Gecensure;
            Debug.Log("ateşşş");
            Instantiate(kursun, kursunCıkıs.position, Quaternion.identity);
        }
    }

    /////////////////////////////////////

    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        vec = new Vector3(horizontal,0,vertical);

        fizik.velocity = vec*karakterhız;
        fizik.position = new Vector3
            (Mathf.Clamp(fizik.position.x, minX, maxX),
             0.0f,
             Mathf.Clamp(fizik.position.z, minZ, maxZ));
        fizik.rotation = Quaternion.Euler(0, 0, fizik.velocity.x*-egim);        


    }
}

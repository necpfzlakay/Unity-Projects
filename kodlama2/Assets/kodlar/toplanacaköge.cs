using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toplanacaköge : MonoBehaviour
{
  
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Rotate(new Vector3(45, 45, 45)*Time.deltaTime);
        //Debug.Log(Time.deltaTime);

    }
}

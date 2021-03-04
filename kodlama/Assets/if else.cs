using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class NewBehaviourScript : MonoBehaviour
{
    public int x;
    public int y;
    public int z;

    void Start()
    {



        if (x > y)
        {
            Debug.Log("ilk sayı ikinciden büyük");
        }

        else if (x < y)
        {
            Debug.Log("ikinci sayı ilkinden büyük");
        }

        else
        {
            Debug.Log("sayılar eşit");
        }









    }
}

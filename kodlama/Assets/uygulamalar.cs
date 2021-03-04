using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uygulamalar : MonoBehaviour
{
    
    void Start()
    {
        //int i = 0;

        //while (i <= 5)
        //{

        //    Debug.Log("MERHABA DUNYA");
        //    i++;
        //}


        string[] oyunlar = {"BRAID","HOTLINE","MIAMI","SUPER MEAT BOY", "TRINE", "LIMBO","MONOCHROMA" };


        for (int i = 0; i < oyunlar.Length; i++)
        {
            if (oyunlar[i]=="LIMBO")
            {
                Debug.Log("LIMBO BULUNDU..");
            }
            else
            {
                Debug.Log("BULUNAMADI..");
            }



        }






    }


    
}

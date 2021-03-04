using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class topkontrol : MonoBehaviour
{

    Rigidbody fizikk;
    public int hizz;
    public int sayac = 0;
    public int toplanılacakobje = 15;
    public Text sayy;
    public Text bitti;

    void Start()
    {
        fizikk = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(yatay, 0, dikey);

        fizikk.AddForce(vec * hizz);




    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("temas oldu");
        if (other.gameObject.tag == "kubb")
        {
            Destroy(other.gameObject);
            //other.gameObject.SetActive(false);
            sayac++;
            //Debug.Log("sayac= " + sayac);
            sayy.text = "Sayac === " + sayac;
            if (sayac == toplanılacakobje)
            {
                //Debug.Log("OYUN BİTTİ");
                bitti.text = "i want to play";
            }
        }
        
        
    }


}

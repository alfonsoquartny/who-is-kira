using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RolCode : MonoBehaviour
{
    public Text oyuncuIs�m;
    public int oyuncuSayi = 0;
    public Text RolText;
    public int roller = 0;
    public bool isL = false;
    public bool isKira = false;

    public GameObject rolEkran�;
    public GameObject acilisEkran�;
    public int dedektifler = 5;
    void Start()
    {
        acilisEkran�.SetActive(true);
        oyuncuSayi = 0;
        rolEkran�.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
   
        oyuncuIs�m.text = ("Oyuncu  :" + oyuncuSayi);

        if (oyuncuSayi > 7)
        {
            oyuncuIs�m.text = "TIME TO GO";
        }

        var minVar = 0;
        var maxVar = 7;


        if (roller == 1&&isKira==false)
        {
            RolText.text = "KIRA";
            isKira = true;
            minVar = 2;
        }
        if (roller == 2)
        {
            RolText.text = "DEDEKTIF";
        }
        if (roller == 3)
        {
            RolText.text = "DEDEKTIF";
        }
        if (roller == 4)
        {
            RolText.text = "DEDEKTIF";
        }
        if (roller == 5)
        {
            RolText.text = "DEDEKTIF";
        }
        if (roller == 6)
        {
            RolText.text = "DEDEKTIF";
        }
        if (roller == 7&&isL==false)
        {

            RolText.text = "L";
            isL = true;
            maxVar = 6;
         
        }

    }
    public void kapat()
    {
        rolEkran�.SetActive(true);
        acilisEkran�.SetActive(false);
    }
    public void rolAc()
    {
        
        var minVar = 1;
        var maxVar = 8;

        oyuncuSayi = oyuncuSayi + 1;
       roller= Random.RandomRange(minVar,maxVar);
     

    }
    

}

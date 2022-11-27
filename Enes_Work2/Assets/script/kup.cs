using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kup : MonoBehaviour
{
    int tamSayi = 100;
    float ondalikli = 101.1f;
    string yazi = "merhaba";
    public int[] rakam;
    List<int> tamSayilar;

   
    void Start()
    {
        tamSayilar = new List<int>();
        tamSayilar.Add(25);
        tamSayilar.Add(112);

        Debug.Log(tamSayilar[0] + tamSayilar[1]);
        toplama();
      
       
        Debug.Log(rakam[0]+rakam[1]);

        Debug.Log("Dizinin eleman sayisi" + rakam.Length);
        Debug.Log("Listenin eleman sayisi" + tamSayilar.Count);

        tamSayilar.Remove(25);
        Debug.Log(tamSayilar.Count);
        tamSayilar.RemoveAt(0);
        Debug.Log(tamSayilar.Count);
      
        
    }

    void toplama()
    {
        tamSayi += tamSayi;
        Debug.Log(tamSayi.ToString());

    }
    
    void Update()
    {
       
    }
}

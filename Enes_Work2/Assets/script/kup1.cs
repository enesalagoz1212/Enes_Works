using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kup1 : MonoBehaviour
{
    GameObject[] nesneler;
    MeshRenderer gorunurluk;
    kup1 kod;

    void Start()
    {
        nesneler = GameObject.FindGameObjectsWithTag("Player");

       /* foreach (GameObject nesne in nesneler)
       {
           nesne.GetComponent<MeshRenderer>().enabled = false;
        }
       */
        for (int i = 0; i < nesneler.Length; i++)
        {
            nesneler[i].GetComponent<MeshRenderer>().enabled = false;
        }
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject kure;
    
    

    private void Start()
    {
        // gameObject.SetActive(false);
        //Debug.Log("nesne pasif oldu");
        // gameObject.SetActive(true);
        //Debug.Log("nesne aktif oldu");

        //Destroy(gameObject, 3.0f);
        for (int i = 0; i <5;i++)
        {
            GameObject yenikure = Instantiate(kure, transform.position, Quaternion.identity);
            Destroy(yenikure);
        }

        
    }
}

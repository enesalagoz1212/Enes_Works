using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kuplerkod : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "kup")
        {
            collision.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }


    }
    
}

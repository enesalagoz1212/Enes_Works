using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klavyeMaus : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Sag ok tusuna basýldý");
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("Sag ok tusundan cekildi");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Sag ok tusuna basýlýyor");
        }





        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Sag ok tusuna basýldý");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Sag ok tusundan cekildi");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Sag ok tusuna basýliyor");
        }










    }









}

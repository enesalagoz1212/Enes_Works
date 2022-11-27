using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // transform.Translate(1*Time.deltaTime, 0, 0,Space.World);

            // transform.Rotate(50 * Time.deltaTime, 0, 0);

            // GetComponent<Rigidbody>().velocity = Vector3.right * 500 * Time.deltaTime;
            // GetComponent<Rigidbody>().velocity = Vector3.left * 500 * Time.deltaTime;
            // GetComponent<Rigidbody>().velocity = Vector3.up * 500 * Time.deltaTime;
            // GetComponent<Rigidbody>().velocity = Vector3.down * 500 * Time.deltaTime;
            // GetComponent<Rigidbody>().velocity = Vector3.back * 500 * Time.deltaTime;
            // GetComponent<Rigidbody>().velocity = Vector3.forward * 500 * Time.deltaTime;


            //  GetComponent<Rigidbody>().velocity = transform.right * 500 * Time.deltaTime;


            GetComponent<Rigidbody>().AddForce(transform.up * 50 * Time.deltaTime);


            




        }
    }










}

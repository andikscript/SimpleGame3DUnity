using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // dipanggil saat pertama kali di running
    void Start()
    {
        Debug.Log("Start");
    }

    // dipanggil terus menerus / setiap frame
    void Update()
    {
        // Input.GetKeyDown : mengambil inputan keyboard dari user
        if (Input.GetKeyDown("up")) 
        {
            // Vector3(x,y,z) : x adalah kanan kiri, y : atas bawah, z = maju mundur
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 2);
        }

        if (Input.GetKeyDown("down"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -2);
        }

        if (Input.GetKeyDown("left"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-2, 0, 0);
        }

        if (Input.GetKeyDown("right"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(2, 0, 0);
        }

        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0,5,0);
        }

        // untuk menstop object
        if (Input.GetKeyDown("s"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }
}

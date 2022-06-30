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
        if (Input.GetKey("up")) 
        {
            // Vector3(x,y,z) : x adalah kanan kiri, y : atas bawah, z = maju mundur
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5);
        }

        if (Input.GetKey("down"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -5);
        }

        if (Input.GetKey("left"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-5, 0, 0);
        }

        if (Input.GetKey("right"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(5, 0, 0);
        }

        // perbedaan GetKey dan GetKeyDown adalah jika GetKey akan menjalankan program saat key pada keyboard 
        // di tekan jika GetKeyDown akan menjalankan program saat key selesai di tekan
        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0,5,0);
        }

        // untuk menstop object
        if (Input.GetKey("s"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }
}

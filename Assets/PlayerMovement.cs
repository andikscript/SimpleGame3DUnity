using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // GetKeyDown akan menjalankan program setelah key di pencet
        if (Input.GetKeyDown("space"))
        {
            // new Vector3(x,y,z) : x adalah kanan kiri, y adalah atas bawah, z adalah maju mundur
            GetComponent<Rigidbody>().velocity = new Vector3(0, 5, 0);
        }

        // GetKey akan menjalankan program saat key dipencet
        if (Input.GetKey("up"))
        {
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

        if (Input.GetKey("s"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        }
    }
}
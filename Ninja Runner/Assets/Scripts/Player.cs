using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Left"))
        {
            transform.position -= new Vector3(1, 0, 0)* speed * Time.deltaTime;
        }
        if (Input.GetButton("Right"))
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetButtonDown("Jump"))
        {
            transform.position += new Vector3(0, 1, 0) * jumpForce * Time.deltaTime;
        }
    }

    
}

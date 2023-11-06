using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator anim;
    public GameManager1 gm;
    [SerializeField] int dashAmount;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        gm = FindObjectOfType<GameManager1>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButton("Left"))
        {
            anim.SetBool("isMoving", true);
            anim.SetBool("isJumping", false);
            transform.position -= new Vector3(1, 0, 0)* speed * Time.deltaTime;
           
        }
        if (Input.GetButton("Right"))
        {
            anim.SetBool("isMoving", true);
            anim.SetBool("isJumping", false);
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
            
        }
        if (Input.GetButtonDown("Jump"))
        {
            
            anim.SetBool("isJumping", true);
            
            
            anim.SetBool("isMoving", false);
            rb.AddForce(new Vector3(rb.velocity.x, jumpForce));

        }

        if (!Input.anyKey)
        {
            anim.SetBool("isMoving", false);
            anim.SetBool("isJumping", false);
        }

        if (gm.pwrAvailable && Input.GetKeyDown("z"))
        {
            transform.position += new Vector3(1, 0, 0) * dashAmount * Time.deltaTime;
            //gm.pwrAvailable = false;
        }

    }

    
}

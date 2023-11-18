using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator anim;
    public GameManager1 gm;
    [SerializeField] int dashAmount;
    [SerializeField] GameObject kunai;
    public int currentScene;
    public float raycastDistance = 0.1f;
    public int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        gm = FindObjectOfType<GameManager1>();
        currentScene = SceneManager.GetActiveScene().buildIndex;
        
        
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, raycastDistance);

            if (Input.GetButton("Left"))
            {
                anim.SetInteger("throw", -1);
                anim.SetFloat("facing", -1);
                direction = -1;
                anim.SetBool("isMoving", true);
                transform.position -= new Vector3(1, 0, 0) * speed * Time.deltaTime;
                


            }
            if (Input.GetButton("Right"))
            {
                anim.SetInteger("throw", 1);
                anim.SetFloat("facing", 1);
                direction = 1;
                anim.SetBool("isMoving", true);
                transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
                

            }
            if (Input.GetButtonDown("Jump") && isGrounded())
            {


                anim.SetTrigger("jumping");
                anim.SetBool("isMoving", false);
                rb.AddForce(new Vector3(rb.velocity.x, jumpForce));

            }

            if (!Input.anyKey)
            {
                anim.SetBool("isMoving", false);
                
            }

           if (gm.pwrAvailable && Input.GetKeyDown("q"))
           {
                gm.pwrAvailable = false;
                if (anim.GetFloat("facing") == 1)
                {
                transform.position += new Vector3(1, 0, 0) * dashAmount * Time.deltaTime;
                }
                else if(anim.GetFloat("facing") == -1)
                {
                transform.position -= new Vector3(1, 0, 0) * dashAmount * Time.deltaTime;
                }
                
                
           }

            if (Input.GetKeyDown("e"))
            {
                anim.SetTrigger("isThrowing");
                Instantiate(kunai, gameObject.transform.position, Quaternion.Euler(0, 0, 270));
            }
        
    }

    bool isGrounded()
    {
        return GetComponent<Rigidbody2D>().velocity.y == 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(gm.levelNumber);
        }

        if(collision.gameObject.tag == "deadZone")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(gm.levelNumber);

        }
    }

    

   

}

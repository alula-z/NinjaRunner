using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
     public GameManager1 gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager1>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collided with scroll");
        if(collision.gameObject.tag == "Player")
        {
            gm.pwrAvailable = true;
            Destroy(gameObject);
        }
    }

    
}

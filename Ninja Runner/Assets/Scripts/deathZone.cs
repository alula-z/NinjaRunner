using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathZone : MonoBehaviour
{
    public playerSpawner pSpawner;
    // Start is called before the first frame update
    void Start()
    {
        pSpawner = GetComponent<playerSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag == "Player")
        {
            Instantiate(collision.gameObject, pSpawner.transform.position,Quaternion.identity);
            
            
        }
    }
}

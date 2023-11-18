using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBound : MonoBehaviour
{
    public Enemy en;
    
    
    // Start is called before the first frame update
    void Start()
    {
        en = FindObjectOfType<Enemy>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            en.multiplier *= -1;
            en.GetComponent<Animator>().SetBool("right", !en.GetComponent<Animator>().GetBool("right"));
        }
    }
}

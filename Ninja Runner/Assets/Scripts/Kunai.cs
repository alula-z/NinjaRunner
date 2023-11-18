using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kunai : MonoBehaviour
{
    [SerializeField] int kunaiSpeed;
    public Player pl;
    [SerializeField] int maxDistance;
    // Start is called before the first frame update
    void Start()
    {
        pl = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * kunaiSpeed * pl.direction  * Time.deltaTime;
        if(gameObject.transform.position.x - pl.transform.position.x > maxDistance)
        {
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathZone : MonoBehaviour
{
    public playerSpawner pSpawner;
    public GameManager1 gm;
    // Start is called before the first frame update
    void Start()
    {
        pSpawner = GetComponent<playerSpawner>();
        gm = FindObjectOfType<GameManager1>();
        if(pSpawner == null)
        {
            Debug.Log("spawner not found");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
    }
}

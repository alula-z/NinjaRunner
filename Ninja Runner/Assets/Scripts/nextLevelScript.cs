using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevelScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        SceneManager.LoadScene("Level0", LoadSceneMode.Single);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
            SceneManager.LoadScene("level1");
        }
    }
}

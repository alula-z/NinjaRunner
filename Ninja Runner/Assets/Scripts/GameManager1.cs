using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    public bool pwrAvailable = false;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(1);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
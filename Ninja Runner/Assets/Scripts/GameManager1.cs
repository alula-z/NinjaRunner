using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    public bool pwrAvailable = false;
    public int levelNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(levelNumber);
        levelNumber++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}

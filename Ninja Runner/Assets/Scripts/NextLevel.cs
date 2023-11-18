using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
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
        if(Input.GetKeyDown("r")&& gm.levelNumber == 8)
        {
            gm.levelNumber = 1;
            SceneManager.LoadScene(gm.levelNumber);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("player entered");
            gm.levelNumber++;
            SceneManager.LoadScene(gm.levelNumber, LoadSceneMode.Single);
            

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerSpawner : MonoBehaviour
{
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {

        Instantiate(player, new Vector3(transform.position.x, transform.position.y), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCam : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 5f;
    public float yOffset = 3.3f;
    public Vector3 maxBound;
    public Vector3 minBound;
    // Start is called before the first frame update
    void Start()
    {
        GameObject background = GameObject.FindGameObjectWithTag("Background");

        
            SpriteRenderer backgroundRenderer = background.GetComponent<SpriteRenderer>();

            
            float halfHeight = backgroundRenderer.bounds.extents.y;
            float halfWidth = backgroundRenderer.bounds.extents.x;

            minBound = new Vector3(background.transform.position.x - halfWidth, background.transform.position.y - halfHeight, -10f);
            maxBound = new Vector3(background.transform.position.x + halfWidth, background.transform.position.y + halfHeight, -10f);
        
        


    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        target = player.transform;

        float clampedX = Mathf.Clamp(target.position.x, minBound.x, maxBound.x);
        float clampedY = Mathf.Clamp(target.position.y + 3.1f, minBound.y, maxBound.y);
        Vector3 newPos = new Vector3(clampedX, clampedY, -10f);
        
        transform.position = Vector3.Slerp(transform.position, newPos, smoothSpeed * Time.deltaTime);

    }
    
}

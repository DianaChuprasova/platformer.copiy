using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    float velocity = 1.5f;
    bool moveLeft = true;
    public Transform groundDetect;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * velocity * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetect.position, Vector2.down, 1f);
        if (!groundInfo.collider)
        {
        if (moveLeft) 
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            moveLeft = false;
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            moveLeft = true;
        }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawControlleres : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player") 
        {
            PlayerConroller player = collision.gameObject.GetComponent<PlayerConroller>();
            player.RecountHealthPoints(-1); 
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * 5F, ForceMode2D.Impulse);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "Player") 
        {
            PlayerConroller player = collision.gameObject.GetComponent<PlayerConroller>();
            player.RecountHealthPoints(-1); 
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * 5F, ForceMode2D.Impulse);
        }
    }
}

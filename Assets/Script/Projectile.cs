using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rb;
    private Collider2D ballCol;
    public static Projectile instance; 

    private void Start()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
        ballCol = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        //rotate ball same as projectile
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(this.gameObject,0.5f);
            Launcher.instance.ballThrown = 0;
        }//Hit ground
        
        if (other.gameObject.CompareTag("Receiver"))
        {
            other.gameObject.GetComponent<Renderer>().material.color = Color.black;
            Launcher.instance.isWin = true;
            UI.instance.youWin.SetActive(true);
        }//Hit Receiver
        
    }
}

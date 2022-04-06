using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    float windtaken;
    Rigidbody2D rb;
    Vector2 movVector;
    WindHandler wh;
    SpellHandler sh;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sh = SpellHandler.instance;
        wh = WindHandler.instance;

    }

    // Update is called once per frame
    void Update()
    {
        windtaken = wh.wind;
        movVector = new Vector2(Input.GetAxis("Horizontal") + windtaken, 0);
    }

    private void FixedUpdate()
    {
        rb.AddForce(movVector * speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //City Entering
        if (other.gameObject.CompareTag("City"))
        {
            FieldManager.instance.isInCityTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("City"))
        {
            FieldManager.instance.isInCityTrigger = false;
        }
    }
}

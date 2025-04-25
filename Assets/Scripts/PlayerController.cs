using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed = 5;
    private float xVel;
    private float yVel;


    void Start()
    {
        
    }

    void Update()
    {
        xVel = Input.GetAxis("Horizontal") * speed;
        yVel = Input.GetAxis("Vertical") * speed;

        rb.velocity = new Vector2(xVel, yVel);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5;
    public float jumpheight;
    public float momentumthreshold;
    public float horizontalthreshhold;
    private int basespeed;
    private float horizontal;
    private float vertical;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        basespeed = (int)speed;
    }

    // Update is called once per frame
    void Update()
    {
    horizontal = Input.GetAxisRaw("Horizontal");
    if(horizontal > horizontalthreshhold){horizontal = horizontalthreshhold;}
    if(horizontal < -horizontalthreshhold){horizontal = -horizontalthreshhold;}
    if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)){speed += 0.001f;}
    else{if(horizontal>0.5){horizontal-=0.5f;}if(horizontal<-0.5){horizontal+=0.5f;}}
    if(speed > momentumthreshold){speed = momentumthreshold;}
    else{speed = basespeed;}
    if(Input.GetKeyDown(KeyCode.Space)){rb.AddForce(new Vector2(0, jumpheight*speed), ForceMode2D.Impulse);Debug.Log("Jump");}
    rb.AddForce(new Vector2(horizontal*speed,0));
    }
}

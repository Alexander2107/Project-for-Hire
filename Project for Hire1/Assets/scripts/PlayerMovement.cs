using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigb;
    public Vector2 pM;
    public float speed = 10f;
    public Animator anim;
    public SpriteRenderer spr;
    // Start is called before the first frame update
    void Start()
    {
        rigb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        flip();
    }

    void Walk()
    {
        pM.x = Input.GetAxis("Horizontal");
        anim.SetFloat("Movhor", Mathf.Abs(pM.x));
        rigb.velocity = new Vector2(pM.x * speed, rigb.velocity.y);
    }

    void flip()
    {
        spr.flipX = pM.x < 0;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigb;
    public Vector2 pM;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rigb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
    }

    void Walk()
    {
        pM.x = Input.GetAxis("Horizontal");
        rigb.AddForce(pM * speed);
    }
}
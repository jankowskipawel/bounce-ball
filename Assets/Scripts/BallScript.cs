﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    public Rigidbody2D rb;
    public float ballForce;
    bool gameStarted;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !gameStarted)
        {
            transform.SetParent(null);
            rb.simulated = true;
            rb.AddForce(new Vector2(ballForce, ballForce));
            gameStarted = true;
        }
    }
}

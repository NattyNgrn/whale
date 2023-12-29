using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class WhaleScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float swimStrength;

    public LogicScript logic;
    public bool whaleIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        myRigidBody = GameObject.FindGameObjectWithTag("WHALE").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && whaleIsAlive == true)
        {
            myRigidBody.velocity = Vector2.up * swimStrength;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //logic.gameOver();
        //whaleIsAlive = false;
    }
}

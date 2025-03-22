using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbScript : MonoBehaviour
{
    //Creating a reference to a rigidbody2d component
    public Rigidbody2D myRigidbody;

    //Decimal value for strength of going up
    public float flapStrength;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Only move the bird up after hitting space button
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = Vector2.up * flapStrength; //Vector2.up is shorthand for (0,1) this means making the bird go up in Y-axis
        }
    }
}

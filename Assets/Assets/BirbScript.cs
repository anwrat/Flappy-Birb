using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbScript : MonoBehaviour
{
    //Creating a reference to a rigidbody2d component
    public Rigidbody2D myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity = Vector2.up*10; //Vector2.up is shorthand for (0,1) this means making the bird go up in Y-axis
    }
}

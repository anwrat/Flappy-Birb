using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float movespeed = 5;
    public float deadzone = -41;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position+(Vector3.left*movespeed) * Time.deltaTime; //Time.delataTime makes sure the movespeed isnot affected by framerate
        if (transform.position.x < deadzone)
        {
            Destroy(gameObject);
        }
    }
}

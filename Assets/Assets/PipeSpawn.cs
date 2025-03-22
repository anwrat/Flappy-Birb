using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    //Reference to the pipe object
    public GameObject pipe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Spawn the pipe using instantiate
        Instantiate(pipe,transform.position,transform.rotation);
    }
}

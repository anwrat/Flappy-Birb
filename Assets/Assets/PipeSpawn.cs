using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    //Reference to the pipe object
    public GameObject pipe;

    public float spawnrate = 2;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            //Spawn the pipe using instantiate
            Instantiate(pipe,transform.position,transform.rotation);
            timer = 0;
        }
    }
}

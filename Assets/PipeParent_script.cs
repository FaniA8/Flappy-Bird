using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeParent_script : MonoBehaviour
{
    // Start is called before the first frame update
    public float pipe_speed = 5;
    public float dead = -15;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * pipe_speed) * Time.deltaTime;

        if (transform.position.x < dead)
        {
            Destroy(gameObject);
        }
    }
}

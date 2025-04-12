using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_respawner : MonoBehaviour
{
    public GameObject Pipe;
    public float respawn_rate = 2;
    private float timer;
    public float y_offset = 10;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < respawn_rate){
            timer += Time.deltaTime;
        }else{
            Spawn();
            timer = 0;
        }
        
    }

    void Spawn(){
        float LeastHeight = transform.position.y - y_offset;
        float MostHeight = transform.position.y + y_offset;
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(LeastHeight, MostHeight), 0), transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birb_script : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapStrength;
    public LogicManage logic;
    private bool Alive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<LogicManage>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Alive)
        {
           myrigidbody.velocity = Vector2.up*flapStrength; 
        }

        if (GameObject.FindGameObjectWithTag("BirdPosition").transform.position.y > 6 || GameObject.FindGameObjectWithTag("BirdPosition").transform.position.y < -6)
        {
            Alive = false;
            logic.GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        Alive = false;
        logic.GameOver();
    }
}

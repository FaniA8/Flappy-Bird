using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreIncrease : MonoBehaviour
{
    // Start is called before the first frame update

    public LogicManage logic;
    public int score_to_add = 1;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<LogicManage>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.layer == 3){
            logic.addScore(score_to_add);
        }
        
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManage : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public Text textScore;
    public GameObject GameOverScreen;

    [ContextMenu("Increase score")]
    public void addScore(int ScoreToAdd){
        score += ScoreToAdd;
        textScore.text = score.ToString();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver(){
        GameOverScreen.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score=0;
    public Text textscore;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    public void GameScore(int ringscore)
    {
        score += ringscore;
        textscore.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

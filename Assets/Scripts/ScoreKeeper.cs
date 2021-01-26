using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public Text score;
    public static int playerScoreNum = 0;
    public Text highScore;
    public static int playerHighScoreNum = 0;
    public static int numPickupsInt = 0;
    public static int numPedsInt = 0;
    public static int numCardsInt = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        score.text = "Score: " + ScoreKeeper.playerScoreNum;


        if (playerHighScoreNum > playerScoreNum)
        {
            highScore.text = "High Score: " + ScoreKeeper.playerHighScoreNum;
        }
        else
        {
            highScore.text = "High Score: " + ScoreKeeper.playerScoreNum;
        }
    }
}

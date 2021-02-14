using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameSceneUIController : MonoBehaviour
{
    public Text HighScore, score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "In this run, you got " + ScoreKeeper.playerScoreNum + " as a score.";
        HighScore.text = "Your highest in-game score was " + ScoreKeeper.playerHighScoreNum + ".";
    }

    public void LoadMainGameOnButtonPress()
    {
        SceneManager.LoadScene(1);
        ScoreKeeper.playerScoreNum = 0;

    }

    public void LoadMainMenuOnButtonPress()
    {
        SceneManager.LoadScene(0);

    }

    public void LoadInstructionsOnButtonPress()
    {
        SceneManager.LoadScene(2);

    }
}

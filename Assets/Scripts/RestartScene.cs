using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartScene : MonoBehaviour
{
    public static float gameTimer;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        gameTimer = 60.0f;

    }

    // Update is called once per frame
    void Update()
    {
        gameTimer -= Time.deltaTime;
        DisplayTime(gameTimer);

        if (gameTimer <= 0)
        {
            SceneManager.LoadScene(3);
            ScoreKeeper.numCardsInt = 0;
            ScoreKeeper.numPedsInt = 0;
            ScoreKeeper.numPickupsInt = 0;
            
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
    }
}

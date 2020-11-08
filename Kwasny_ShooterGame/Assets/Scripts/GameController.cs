using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController ThisInstance = null;
    public static int Score;
    public string ScorePrefix = string.Empty;
    public Text ScoreText = null;
    public Text GameOverText = null;

    void Awake()
    {
        ThisInstance = this;

      
    }

    private void Update()
    {
        if (ScoreText != null)
            ScoreText.text = ScorePrefix + Score.ToString();

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
    
    public static void GameOver()
    {
        if (ThisInstance.GameOverText != null)
            ThisInstance.GameOverText.gameObject.SetActive(true);
    }
}

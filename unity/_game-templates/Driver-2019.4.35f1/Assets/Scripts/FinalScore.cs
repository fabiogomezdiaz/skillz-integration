using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScore : MonoBehaviour
{
    [SerializeField] private TMP_Text finalScoreText;
    [SerializeField] private TMP_Text highScoreText;

    public const string Scene = "Scene_FinalScore";

    private void Start()
    {
        int finalScore = PlayerPrefs.GetInt(ScoreSystem.FinalScoreKey, 0);
        int highScore = PlayerPrefs.GetInt(ScoreSystem.HighScoreKey, 0);

        finalScoreText.text = $"Final Score: {finalScore}";
        highScoreText.text = $"High Score: {highScore}";
    }

    public void ViewResults()
    {
        SceneManager.LoadScene(MainMenu.Scene);
    }
}

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
    private int finalScore;
    private int _retrySeconds = 3;

    private void Start()
    {
        finalScore = PlayerPrefs.GetInt(ScoreSystem.FinalScoreKey, 0);
        int highScore = PlayerPrefs.GetInt(ScoreSystem.HighScoreKey, 0);

        finalScoreText.text = $"Final Score: {finalScore}";
        highScoreText.text = $"High Score: {highScore}";

        // Submit Score
        //TryToSubmitScore(finalScore);
    }

    public void ViewResults()
    {
        SceneManager.LoadScene(MainMenu.Scene);
        // Go back to Skillz
        //SkillzCrossPlatform.ReturnToSkillz();
    }

    /*void TryToSubmitScore(int score) {
        SkillzCrossPlatform.SubmitScore(score, OnSuccess, OnFailure);
    }

    void OnSuccess() {
        Debug.Log("Success");
    }

    void OnFailure(string reason) {
        Debug.LogWarning("Fail: " + reason);
        StartCoroutine(RetrySubmit());
    }

    IEnumerator RetrySubmit() {
        yield return new WaitForSeconds(_retrySeconds);
        TryToSubmitScore(finalScore);
    }*/
}

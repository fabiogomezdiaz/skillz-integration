//using SkillzSDK;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScore : MonoBehaviour
{
    [SerializeField] private TMP_Text finalScoreText;
    [SerializeField] private TMP_Text highScoreText;

    public const string Scene = "FinalScore";
    private int finalScore;
    private int _retryDelayInSeconds = 3;

    private void Start()
    {
        finalScore = PlayerPrefs.GetInt(ScoreSystem.FinalScoreKey, 0);
        int highScore = PlayerPrefs.GetInt(ScoreSystem.HighScoreKey, 0);

        finalScoreText.text = $"Final Score: {finalScore}";
        highScoreText.text = $"High Score: {highScore}";
    }

    public void ViewResults()
    {
        Debug.Log("Clicked \"View Results\" Button");
        SceneManager.LoadScene(MainMenu.Scene);

        // Go back to Skillz
        // TryToSubmitScore(finalScore);
    }
    /*
    ////////////////////////////
    // SUBMIT SCORE TO SKILLZ //
    ////////////////////////////

    void TryToSubmitScore(int score) {
        Debug.Log("Submitting score to Skillz!");
        SkillzCrossPlatform.SubmitScore(score, OnSubmitScoreSuccess, OnSubmitScoreFailure);
    }

    void OnSubmitScoreSuccess() {
        Debug.Log("Successfully submitted score to Skillz!");
        //SkillzCrossPlatform.ReturnToSkillz();
        UpdateCustomPlayerData();
    }

    void OnSubmitScoreFailure(string reason) {
        Debug.Log($"Fail to submit score to Skillz: {reason}");
        StartCoroutine(RetrySubmitScore());
    }

    IEnumerator RetrySubmitScore() {
        Debug.LogWarning($"Retrying to submit score to Skillz in \"{_retryDelayInSeconds}\" seconds");
        yield return new WaitForSeconds(_retryDelayInSeconds);
        TryToSubmitScore(finalScore);
    }

    //////////////////////////////////////////////////
    // UPDATE SKILLZ PROGRESSION CUSTOM PLAYER DATA //
    //////////////////////////////////////////////////

    void UpdateCustomPlayerData() {
        // Create Date String
        string newDate = System.DateTime.Now.ToString();

        Debug.Log($"newDate string: \"{newDate}\"");

        // Create Update Dictionary
        Dictionary<string, object> updateDict = new Dictionary<string, object>()
        {
            { Progression.CPDLastPlayed, newDate }
        };

        SkillzCrossPlatform.UpdateProgressionUserData(ProgressionNamespace.PLAYER_DATA, updateDict, OnUpdateCustomPlayerDataSuccess, OnUpdateCustomPlayerDataFail);
    }

    void OnUpdateCustomPlayerDataSuccess()
    {
        Debug.Log("Successfully updated Custom Player Data!");
        SkillzCrossPlatform.ReturnToSkillz();
    }

    void OnUpdateCustomPlayerDataFail(string reason)
    {
        Debug.Log($"Failed to update Custom Player Data: {reason}");
    }*/
}

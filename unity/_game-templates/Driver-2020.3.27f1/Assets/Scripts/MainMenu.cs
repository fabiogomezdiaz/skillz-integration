using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text highScoreText;
    [SerializeField] private TMP_Text unityVersionText;

    public const string Scene = "MainMenu";

    private void Start()
    {
        int highScore = PlayerPrefs.GetInt(ScoreSystem.HighScoreKey, 0);

        highScoreText.text = $"High Score: {highScore}";
        unityVersionText.text = $"Unity Version: {Application.unityVersion}";
    }

    public void Play()
    {
        SceneManager.LoadScene(Car.Scene);
        // SkillzCrossPlatform.LaunchSkillz(new SkillzGameController());
    }
}

//using SkillzSDK;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Progression : MonoBehaviour
{
    [SerializeField] private TMP_Text gamesPlayedText;
    [SerializeField] private TMP_Text gamesWonText;
    [SerializeField] private TMP_Text averageScoreText;
    [SerializeField] private TMP_Text lastPlayedText;

    public const string Scene = "Progression";

    /*public void Return()
    {
        Debug.Log("Clicked \"Return\" Button");
        SkillzCrossPlatform.ReturnToSkillz();
    }

    private void Start()
    {
        GetSkillzDefaultPlayerData();
        GetSkillzCustomPlayerData();
    }

    //////////////////////////////////////////
    // GET SKILLZ DEFAULT PLAYER DATA (DPD) //
    //////////////////////////////////////////

    // Define list of keys to look up within the target namespace
    private const string DPDGamesPlayed = "games_played";
    private const string DPDGamesWon = "games_won";
    private const string DPDAverageScore = "average_score";

    public void GetSkillzDefaultPlayerData()
    {
        List<string> keys = new List<string>()
        {
            DPDGamesPlayed,
            DPDGamesWon,
            DPDAverageScore
        };

        Debug.Log("Getting Default Player Data...");
        SkillzCrossPlatform.GetProgressionUserData(ProgressionNamespace.DEFAULT_PLAYER_DATA, keys, OnReceivedDefaultPlayerData, OnReceivedDefaultPlayerDataFail);
    }

    void OnReceivedDefaultPlayerData(Dictionary<string, SkillzSDK.ProgressionValue> data)
    {
        Debug.Log("Received Default Player Data!");

        foreach(var kvp in data) {
            Debug.Log($"(Progression Default Player Data) key: \"{kvp.Key}\", value: \"{kvp.Value.Value}\"");

            switch (kvp.Key) {
                case DPDGamesPlayed:
                    gamesPlayedText.text = $"Games Played: {kvp.Value.Value}";
                    break;
                case DPDGamesWon:
                    gamesWonText.text = $"Games Won: {kvp.Value.Value}";
                    break;
                case DPDAverageScore:
                    averageScoreText.text = $"Average Score: {kvp.Value.Value}";
                    break;
                default:
                    Debug.Log("Nothing");
                    break;
            }
        }
    }

    void OnReceivedDefaultPlayerDataFail(string reason)
    {
        Debug.Log($"Failed to retrieve Default Player Data: {reason}");
    }

    /////////////////////////////////////////
    // GET SKILLZ CUSTOM PLAYER DATA (CPD) //
    /////////////////////////////////////////

    public const string CPDLastPlayed = "LastPlayed";

    public void GetSkillzCustomPlayerData()
    {
        List<string> keys = new List<string>()
        {
            CPDLastPlayed
        };

        Debug.Log("Getting Custom Player Data...");
        SkillzCrossPlatform.GetProgressionUserData(ProgressionNamespace.PLAYER_DATA, keys, OnReceivedCustomPlayerData, OnReceivedCustomPlayerDataFail);
    }

    void OnReceivedCustomPlayerData(Dictionary<string, SkillzSDK.ProgressionValue> data)
    {
        Debug.Log("Received Custom Player Data!");

        foreach(var kvp in data) {
            Debug.Log("(Progression Custom Player Data) key: \"{kvp.Key}\", value: \"{kvp.Value.Value}\"");

            switch (kvp.Key) {
                case CPDLastPlayed:
                    lastPlayedText.text = $"Last Played: {kvp.Value.Value}";
                    break;
                default:
                    Debug.Log("Nothing");
                    break;
            }
        }

    }

    void OnReceivedCustomPlayerDataFail(string reason)
    {
        Debug.Log($"Failed to retrieve Custom Player Data: {reason}");
    }*/
}

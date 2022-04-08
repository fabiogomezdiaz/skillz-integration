/*using SkillzSDK;
using UnityEngine.SceneManagement;

public sealed class SkillzGameController : SkillzMatchDelegate
{
    private const string GameScene            = Car.Scene;  // Your game scene name
    private const string ProgressionRoomScene = Progression.Scene; // Your player progression room
    private const string StartMenuScene       = MainMenu.Scene;  // Your menu scene exiting Skillz will return to (optional)

    // Called when a player chooses a tournament and the match countdown expires
    public void OnMatchWillBegin(Match matchInfo) {
        // This is where you launch into your competitive gameplay
        SceneManager.LoadScene(GameScene);
    }

    // Called when a player clicks the Progression entry point or side menu. Explained in later steps
    public void OnProgressionRoomEnter() {
        SceneManager.LoadScene(ProgressionRoomScene);
    }

    // Called when a player chooses Exit Skillz from the side menu
    public void OnSkillzWillExit() {
        SceneManager.LoadScene(StartMenuScene);
    }
}*/
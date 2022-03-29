//
//  AppDelegate.swift
//  skillz-integration
//
//  Created by Fabio Gomez Diaz on 10/30/21.
//

import UIKit
import Skillz

@UIApplicationMain
class AppDelegate: UIResponder, UIApplicationDelegate, SkillzDelegate {

    var window: UIWindow?

    func application(_ application: UIApplication, didFinishLaunchingWithOptions launchOptions: [UIApplication.LaunchOptionsKey: Any]?) -> Bool {
        // Override point for customization after application launch.
        Skillz.skillzInstance().initWithGameId("PUT_GAME_ID_HERE", for: self, with: SkillzEnvironment.sandbox, allowExit: true)
        return true
    }

    // MARK: UISceneSession Lifecycle

    /*func application(_ application: UIApplication, configurationForConnecting connectingSceneSession: UISceneSession, options: UIScene.ConnectionOptions) -> UISceneConfiguration {
        // Called when a new scene session is being created.
        // Use this method to select a configuration to create the new scene with.
        return UISceneConfiguration(name: "Default Configuration", sessionRole: connectingSceneSession.role)
    }

    func application(_ application: UIApplication, didDiscardSceneSessions sceneSessions: Set<UISceneSession>) {
        // Called when the user discards a scene session.
        // If any sessions were discarded while the application was not running, this will be called shortly after application:didFinishLaunchingWithOptions.
        // Use this method to release any resources that were specific to the discarded scenes, as they will not return.
    }*/

    // Called when a player chooses a tournament and the match countdown expires
    func tournamentWillBegin(_ gameParameters: [AnyHashable : Any], with matchInfo: SKZMatchInfo) {

        if gameParameters[AnyHashable("config")] != nil {
            let str = gameParameters[AnyHashable("config")] as! String;
            print("Testing config: \(str)")

            // Modify your game's time limit for this match
        }
        let vc = self.window?.rootViewController as! ViewController
        vc.startNewGame()
    }

    // Called when a player clicks the Progression entry point or side menu. Explained in later steps
    func onProgressionRoomEnter() {
        //let vc = self.window?.rootViewController as! ViewController
        //viewController.showProgressionRoom()
    }

    // Called when a player chooses Exit Skillz from the side menu
    func skillzWillExit() {
        //viewController.mainMenu()
    }

}


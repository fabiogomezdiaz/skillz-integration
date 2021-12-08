//
//  ViewController.swift
//  skillz-integration
//
//  Created by Fabio Gomez Diaz on 10/30/21.
//

import UIKit
import Skillz

class GameController: UIViewController, UIAlertViewDelegate {

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }
    
    override func viewDidAppear(_ animated: Bool) {
        super.viewDidAppear(animated)
        
        if submittedScore {
            returnToHomeScreen()
        }
        
    }

    var submittedScore: Bool = false

    @IBOutlet weak var scoreField: UITextField!
    
    @IBAction func submitScore(_ sender: Any) {
        if scoreField.text == "" {
            self.showAlert(title: "Fail",
                           msg: "Please enter your score (i.e. 500-100)",
                           style: .alert,
                           returnToSkillz: false
            )
            return
        }

        let scoreString: String! = scoreField.text
        print("scoreString = \(scoreString!)")
        let score: NSNumber! = NSNumber(value: Int(scoreString)!)
        print("score = \(score!)")

        Skillz.skillzInstance().submitScore(
            score,
            withSuccess: {
                self.submittedScore = true
                self.showAlert(title: "Success!",
                               msg: "Score submitted!",
                               style: .alert,
                               returnToSkillz: true
                )
                
            }, withFailure: {_ in
                self.showAlert(title: "Fail",
                               msg: "Fail to Submit Score!",
                               style: .alert,
                               returnToSkillz: false
                )
            }
        )
    }
    
    func showAlert(title: String, msg: String, style: UIAlertController.Style, returnToSkillz: Bool) {
        print(title)
        let alert = UIAlertController(title: title, message: msg, preferredStyle: style)
        
        if returnToSkillz {
            alert.addAction(UIAlertAction(title: "OK", style: .default, handler: { action in
                let canReturn = Skillz.skillzInstance().returnToSkillz() { [self] in
                    // make sure to clean things up if needed
                    print("Returning to Skillz")
                    view.removeFromSuperview()
                    removeFromParent()
                }
            }))
            
        } else {
            alert.addAction(UIAlertAction(title: "OK", style: .default, handler: nil))
        }
        
        self.present(alert, animated: true)
    }
    
    func returnToHomeScreen() {
        print("Returning to home screen")
        dismiss (animated: true, completion: nil)
    }
}


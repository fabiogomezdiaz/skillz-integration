//
//  ViewController.swift
//  skillz-integration
//
//  Created by Fabio Gomez Diaz on 10/30/21.
//

import UIKit
import Skillz

class ViewController: UIViewController {

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }

    @IBAction func startGame(_ sender: Any) {
        Skillz.skillzInstance().launch()
    }
    
    func startNewGame() {
        let storyboard = UIStoryboard(name: "Main", bundle: nil)
        let secondVC = storyboard.instantiateViewController(identifier: "GameController")
        
        secondVC.modalPresentationStyle = .fullScreen
        secondVC.modalTransitionStyle = .crossDissolve
        
        present(secondVC, animated: true, completion: nil)
    }
    
}


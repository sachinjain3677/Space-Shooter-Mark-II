using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    
    public float startWait;
    public float waveWait;

    
    public GUIText restartText;
    public GUIText gameOverText;


    private bool gameOver;
    private bool restart;
    
    void Start() {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        
    }

    void Update() {
        if (restart) {
            if (Input.GetKeyDown(KeyCode.R)) {
                Application.LoadLevel (Application.loadedLevel);
            }
        }
    }

    

    

    
     
    public void GameOver() {
        gameOverText.text = "Game Over!!";
        gameOver = true; 
		restartText.text = "Press 'R' to restart";
		restart = true;
    }
}

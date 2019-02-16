using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    private bool gameOver;
    private bool winGame;

    public GameObject GameOver;
    public static GameController instance;
    public GameObject StartGame;
    public GameObject WinGame;
    
    void Awake() {
        if( instance == null ) {
            StartGame.SetActive( true );
            instance = this;
        } else if( instance != null ) {
            Destroy( gameObject );
        }
    }
    void Update() {
        if( gameOver && Input.GetKeyDown( KeyCode.R ) ) {
            SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
        }
        if( winGame && Input.GetKeyDown( KeyCode.Space ) ) {
            SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
        }
    }

    public void Kill() {
        WinGame.SetActive( false );
        StartGame.SetActive( false );
        GameOver.SetActive( true );
        gameOver = true;
    }

    public void Win() {
        GameOver.SetActive( false );
        StartGame.SetActive( false );
        WinGame.SetActive( true );
        winGame = true;
    }
	
}

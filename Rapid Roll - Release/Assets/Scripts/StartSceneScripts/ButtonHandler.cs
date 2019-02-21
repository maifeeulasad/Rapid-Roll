using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;


    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    void Update()
    {
        
    }

    void StartGame()
    {
        Util.isGameOver = false;
        Util.playerHealth = 5;
        //new Thread(StartGameScene).Start();
        StartGameScene();
       
    }

    void ExitGame()
    {
        Application.Quit();
    }

    private void StartGameScene()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

    }

}

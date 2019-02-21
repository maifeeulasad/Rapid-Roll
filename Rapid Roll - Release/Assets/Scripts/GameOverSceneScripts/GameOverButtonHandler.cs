using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverButtonHandler : MonoBehaviour
{
    public Button menuButton;


    void LoadStartScene()
    {
        SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
    }

    void Start()
    {
        menuButton.onClick.AddListener(LoadStartScene);
    }

    void Update()
    {
        
    }
}

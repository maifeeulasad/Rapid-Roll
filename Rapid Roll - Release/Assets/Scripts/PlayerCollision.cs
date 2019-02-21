using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void StartGameOverScene()
    {
         StartCoroutine(StartGameOverScene(true));
            
        
    }


    public static IEnumerator StartGameOverScene(bool x)
    {
        yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene("GameOverScene", LoadSceneMode.Single);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag.Equals("bdes") || collision.collider.tag.Equals("bar_down"))
        {
            Util.isGameOver = true;
            StartGameOverScene();
        }
    }


}

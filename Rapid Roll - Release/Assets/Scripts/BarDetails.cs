using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BarDetails : MonoBehaviour
{

    public bool isKiller = false;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
        if (!isKiller)
            return;
        if(collision.collider.tag.Equals("Player"))
        {
            if(Util.playerHealth==1)
            {
                Util.isGameOver = true;
                StartGameOverScene();
            }
            --Util.playerHealth;
            Debug.Log(Util.playerHealth);
        }
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


}

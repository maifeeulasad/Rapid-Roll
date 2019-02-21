using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour
{

    public GameObject bar;

    void Start()
    {
        StartCoroutine(generate());
    }


    private IEnumerator generate()
    {

        while(!Util.isGameOver)
        {
            GameObject tem= Instantiate(bar, this.transform.position + new Vector3(Random.Range(-1.7f,1.7f),0,0), this.transform.rotation);
            if ((int)Random.Range(10, 100) % 2==1)
            {
                tem.GetComponent<BarDetails>().isKiller = true;
                tem.GetComponent<SpriteRenderer>().color = Color.red;
            }
            else
            {
                tem.GetComponent<BarDetails>().isKiller = false;
                tem.GetComponent<SpriteRenderer>().color = Color.blue;

            }

            tem.gameObject.transform.parent = this.gameObject.transform;
            yield return new WaitForSeconds(0.8f);
        }

    }

    void Update()
    {
        
    }



}

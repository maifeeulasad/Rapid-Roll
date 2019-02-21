using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBar : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag=="bar")
        {
            Destroy(collision.collider.gameObject);
        }
    }

}

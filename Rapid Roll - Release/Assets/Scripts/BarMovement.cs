using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMovement : MonoBehaviour
{
    public float mul = 0.1f;

    void Start()
    {
        
    }
    
    void Update()
    {
        if(!Util.isGameOver)
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.up * mul;

        }

    }
}

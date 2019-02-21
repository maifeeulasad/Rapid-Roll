using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    private Rigidbody2D rigidbody;

    private float xMul = 20;
    private float yMul = 40;

    private float jumpMod = 3.5f;


    private bool isTouched = false;
    
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();
        StartCoroutine(ChangeColor());
    }

    private IEnumerator ChangeColor()
    {
        while (true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1, 0.15f, 1, 0.15f, 0.85f);
            yield return new WaitForSeconds(1);

        }
    }


    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(!Util.isGameOver)
        {
            if (Input.GetKey(KeyCode.A))
            {
                rigidbody.AddForce(Vector2.left * xMul);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                rigidbody.AddForce(Vector2.right * xMul);
            }
            else if (Input.GetKey(KeyCode.W) && isTouched)
            {
                rigidbody.AddForce(Vector2.up * yMul * jumpMod);
            }
            else if (Input.GetKey(KeyCode.S) && isTouched)
            {
                rigidbody.AddForce(Vector2.down * yMul);
            }
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isTouched = true;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        isTouched = false;
    }

}

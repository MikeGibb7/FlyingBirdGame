using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duckMoves : MonoBehaviour
{
    public float jumpForce = 2f;
    public float forwardSpeed = 2f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        forwardSpeed += (Time.deltaTime/20);
        if(transform.position.y < -3.25 || transform.position.y > 3.25)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                rb.velocity = Vector2.up * jumpForce;
            }
        }
        rb.velocity = new Vector2(forwardSpeed, rb.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Pipe")
        {
            // Restart the game
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }
    }
   
}
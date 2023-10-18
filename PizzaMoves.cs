using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaMoves : MonoBehaviour
{
    public float speed = 1.6F;
    public GameObject pipe;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += -transform.right * speed * Time.deltaTime;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            Destroy(gameObject);
            pipe.SendMessage("AddScore");
        }
    }
}

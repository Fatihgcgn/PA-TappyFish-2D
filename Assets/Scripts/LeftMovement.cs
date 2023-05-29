using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovement : MonoBehaviour
{
    public float speed;
    BoxCollider2D box;
    float groundWidth;
    float obstacleWidth;
    void Start()
    {
        if(gameObject.CompareTag("Ground"))
        {
            box = GetComponent<BoxCollider2D>();
            groundWidth = box.size.x;
        }
        else if(gameObject.CompareTag("Obstacle"))
        {
            obstacleWidth = GameObject.FindGameObjectWithTag("Column").GetComponent<BoxCollider2D>().size.x;
        }
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

        if(gameObject.CompareTag("Ground"))
        {
            if (transform.position.x < -groundWidth) // kendisi sola kay?p -13 yerine gelince 26 art?yor ve ana fikir olarak sa?a 13 at?l?m(öteleme) yap?yor sonsuz bir yol örgüsü oluyor.
            {
                transform.position = new Vector2(transform.position.x + 2 * groundWidth, transform.position.y);
            }
        }
        else if(gameObject.CompareTag("Obstacle"))
        {
            if(transform.position.x < GameManager.bottomLeft.x - obstacleWidth)
            {
                Destroy(gameObject);
            }
        }

        
    }
}

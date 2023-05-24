using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovement : MonoBehaviour
{
    public float speed;
    BoxCollider2D box;
    float groundWidth;

    void Start()
    {
        box=GetComponent<BoxCollider2D>();
        groundWidth = box.size.x;
        
    }

    
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

        if(transform.position.x < -groundWidth) // kendisi sola kay?p -13 yerine gelince 26 art?yor ve ana fikir olarak sa?a 13 at?l?m(öteleme) yap?yor sonsuz bir yol örgüsü oluyor.
        {
            transform.position = new Vector2(transform.position.x + 2 * groundWidth, transform.position.y);
        }
    }
}

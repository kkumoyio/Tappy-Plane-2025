using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 5;
    public float xOffset = 1;
    public float yOffset = 2;
    
    void Start()
    {
        Vector3 pos = new();
        pos.x  = Random.Range(-xOffset, xOffset);
        pos.y   = Random.Range(-yOffset, yOffset);
        
        transform.position += pos;
    }


    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}

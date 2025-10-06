using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public float jumpForce = 10;
    public int score = 0;
    
    private Rigidbody2D rb;
    
    void Start()
    {
        //get component from the same game object this script is on
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) && rb.velocity.y<0)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        if (rb.velocity.y < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, -30);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 30);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Point"))
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
}

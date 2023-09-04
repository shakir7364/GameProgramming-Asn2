using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]
    Text scoreText;
    [SerializeField]
    Image healthBar;

    int score;

    private Rigidbody2D rb2d;
    private float horizontal;
    private float verticle;
    private Vector2 movement;
    private float maxHealth;
    private float currentHealth;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        maxHealth = 100;
        currentHealth = 100;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Translate(new Vector2(-.15f, 0));
        if (Input.GetKey(KeyCode.D))
            transform.Translate(new Vector2(.15f, 0));
        if (Input.GetKey(KeyCode.S))
            transform.Translate(new Vector2(0, -.15f));
        if (Input.GetKey(KeyCode.W))
            transform.Translate(new Vector2(0, .15f));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            score += 1;
            scoreText.text = score.ToString();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "RedBox")
        {
            if (currentHealth > 0)
                currentHealth -= 1;
            healthBar.fillAmount = currentHealth / maxHealth;
        }
        if(collision.gameObject.tag == "GreenBox")
        {
            if (currentHealth < 100)
                currentHealth += 1;
            healthBar.fillAmount = currentHealth / maxHealth;
        }
    }
}

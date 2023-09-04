using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField]
    private Image healthBar;

    private float maxHealth;
    private float currentHealth;

    // Use this for initialization
    void Start()
    {
        maxHealth = 100;
        currentHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            if (currentHealth > 0)
                currentHealth -= 1;
            healthBar.fillAmount = currentHealth / maxHealth;
        }

        if (Input.GetKey(KeyCode.E))
        {
            if (currentHealth < 100)
                currentHealth += 1;
            healthBar.fillAmount = currentHealth / maxHealth;
        }
    }
}

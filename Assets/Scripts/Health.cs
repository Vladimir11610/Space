using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    public int maxHealth = 100;

    public int health = 100;

    public Sprite[] healthImages;

    public Image mainHealthImage;

    private float healthPart;

    public GameObject GameOverScreen;
    
    void Start()
    {
        mainHealthImage.sprite = healthImages[0];
        healthPart = 1.0f / (healthImages.Length - 1);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        float healthPercent = (float)health / (float)maxHealth;

        int healthParts = (int)((float)healthPercent / (float)healthPart) + 2;

        mainHealthImage.sprite = healthImages[Mathf.Clamp((healthImages.Length - healthParts), 0, healthImages.Length - 1)];

        if (health <= 0) 
        {
            Time.timeScale = 0;
            GameOverScreen.SetActive(true);
        }
    }


}

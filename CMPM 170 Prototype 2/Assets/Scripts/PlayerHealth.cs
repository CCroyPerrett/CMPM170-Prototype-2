using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth Instance { get; private set; } 

    [SerializeField] private int maxHealth;
    [SerializeField] private int numHearts;

    [SerializeField] private Image[] heartImgs;
    [SerializeField] private Sprite fullHeart;
    [SerializeField] private Sprite emptyHeart;
    private int currentHealth;

    // Instantiate the PlayerHealth singleton
    void Awake() 
    {
        if (Instance != null && Instance != this) 
            Destroy(gameObject);
        else 
            Instance = this;
        
    }

    void Start() 
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0) 
        {
            // Game Over
            Debug.Log("Game Over");
        }
        
        if (currentHealth > numHearts) 
            currentHealth = numHearts;

        for (int i = 0; i < heartImgs.Length; i++) 
        {
            if (i < currentHealth) 
                heartImgs[i].sprite = fullHeart;
            else
                heartImgs[i].sprite = emptyHeart;

            if (i < numHearts) 
                heartImgs[i].enabled = true;
            else
                heartImgs[i].enabled = false;
        }
    }

    // Public method to damage the player
    public void DamagePlayer() 
    {
        currentHealth -= 1;
    }

    // Public method to heal the player
    public void HealPlayer()
    {
        currentHealth += 1;
    }

    // Public method to reset the player health
    public void ResetPlayerHealth()
    {
        currentHealth = maxHealth;
    }
}

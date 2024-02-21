using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth Instance;
    public HealthBar HealthBar;

    public int currentHealth;
    public int maxHealth;

    public float invicibleLength;
    private float invicibleCounter;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        HealthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (invicibleCounter > 0)
        {
            invicibleCounter-= Time.deltaTime;
        }
    }

    public void DealDamage()
    {
        if (invicibleCounter <= 0)
        {

            
            currentHealth--;
            HealthBar.SetHealth(currentHealth);

            if (currentHealth <= 0)
            {
                gameObject.SetActive(false);
            }
            else
            {
                invicibleCounter = invicibleLength;
            }
        }
    }
}

using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] 
    private float currentHealth = 5;
    
    [SerializeField]
    private float maxHealh = 5;

    [SerializeField] 
    private FloatingHealthBar healthBar;

    private void Start()
    {
        healthBar.UpdateHealthBar(currentHealth, maxHealh);
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        healthBar.UpdateHealthBar(currentHealth, maxHealh);
    }
}

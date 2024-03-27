using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] 
    private float currentHealth = 3;
    
    [SerializeField]
    private float maxHealh = 3;

    [SerializeField] 
    private FloatingHealthBar healthBar;

    private void Start()
    {
        healthBar.UpdateHealthBar(currentHealth, maxHealh);
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        EnemyDie();
        healthBar.UpdateHealthBar(currentHealth, maxHealh);
    }

    private void EnemyDie()
    {
        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}

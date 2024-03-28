using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] 
    private float currentHealth = 5;
    
    [SerializeField]
    private float maxHealh = 5;

    [SerializeField] 
    private FloatingHealthBar healthBar;

    [SerializeField] 
    private LosePanel losePanel;

    private void Start()
    {
        healthBar.UpdateHealthBar(currentHealth, maxHealh);
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        healthBar.UpdateHealthBar(currentHealth, maxHealh);
        PlayerDie();
    }

    private void PlayerDie()
    {
        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
            losePanel.OpenLosePanel();
        }
    }
}

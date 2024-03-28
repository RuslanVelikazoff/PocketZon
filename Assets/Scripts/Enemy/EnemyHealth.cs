using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] 
    private float currentHealth = 3;
    
    [SerializeField]
    private float maxHealh = 3;

    [SerializeField] 
    private GameObject dropPrefab;
    
    [SerializeField] 
    private FloatingHealthBar healthBar;

    private ScoreUI scoreUI;

    private void Start()
    {
        scoreUI = FindObjectOfType<ScoreUI>();
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
            Instantiate(dropPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            scoreUI.AddScore();
        }
    }
}

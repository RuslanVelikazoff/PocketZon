using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] 
    private float damage;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(Constants.Data.PLAYER))
        {
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
        }
    }
}

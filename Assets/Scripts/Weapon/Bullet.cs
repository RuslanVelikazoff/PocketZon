using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed = 4;
    [SerializeField] 
    private float lifeTime;
    
    [SerializeField] 
    private Rigidbody2D rigidbody;

    private void OnEnable()
    {
        rigidbody.velocity = transform.right * speed;
        Destroy(this.gameObject, lifeTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(Constants.Data.ENEMY))
        {
            other.gameObject.GetComponent<EnemyHealth>().TakeDamage(1);
            Destroy(this.gameObject);
        }

        if (other.gameObject.CompareTag(Constants.Data.BORDER))
        {
            Debug.Log("Border");
            Destroy(this.gameObject);
        }
    }
}

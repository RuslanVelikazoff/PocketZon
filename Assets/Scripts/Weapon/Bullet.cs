using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed;
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
            Debug.Log("Kill");
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag(Constants.Data.BORDER))
        {
            Debug.Log("Border");
            Destroy(this.gameObject);
        }
    }
}

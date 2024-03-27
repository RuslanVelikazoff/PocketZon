using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private int bulletCount = 30;

    private Vector3 bulletSpawn;
    
    [SerializeField] 
    private GameObject bulletPrefab;

    [SerializeField] 
    private GunUI gunUI;

    private void Start()
    {
        gunUI.SetBulletCount(bulletCount);
    }

    public void Fire()
    {
        bulletSpawn = new Vector3(
            transform.position.x + .5f,
            transform.position.y,
            transform.position.z);
        
        if (bulletCount > 0)
        {
            bulletCount -= 1;
            Instantiate(bulletPrefab, bulletSpawn, Quaternion.identity);
        }
        gunUI.SetBulletCount(bulletCount);
    }
}

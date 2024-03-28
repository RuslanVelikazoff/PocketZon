using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private float yMaxPosition;
    [SerializeField]
    private float yMinPosition;
    
    [SerializeField] 
    private float xMaxPosition;
    [SerializeField] 
    private float xMinPosition;

    [SerializeField] 
    private GameObject zombiePrefab;
    [SerializeField] 
    private GameObject spiderPrefab;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        for (int i = 0; i < 3; i++)
        {
            SpawnRandomEnemy();
        }
    }

    private void SpawnRandomEnemy()
    {
        int enemy = Random.Range(0, 2);

        if (enemy == 0)
        {
            Instantiate(zombiePrefab, SpawnPosition(), Quaternion.identity);
        }
        else if (enemy == 1)
        {
            Instantiate(spiderPrefab, SpawnPosition(), Quaternion.identity);
        }
        else
        {
            Debug.Log("Error");
        }
    }

    private Vector2 SpawnPosition()
    {
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = Random.Range(yMinPosition, yMaxPosition);

        return new Vector2(x, y);
    }
}

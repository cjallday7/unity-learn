using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate (enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    }

    //generating random spawn position
    private Vector3 GenerateSpawnPosition()
    {
        spawnPosX = Random.Range(-spawnRange, spawnRange);
        spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

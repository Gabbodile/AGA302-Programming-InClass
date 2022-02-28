using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public string[] enemyNames;
    public Transform[] spawnPoints;
    public GameObject[] enemyTypes;

    public List<GameObject> enemies;

    
    void Start()
    {
        enemies.Add(enemyTypes[0]);
        print(enemyTypes[0].name);
        print("array length: " + enemies.Count);

        enemies.Remove(enemies[0]);

        for (int i = 0; i < 101; i++)
        {
            print(i);
        }

        SpawnEnemy();
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
            KillEnemy(enemies[0]);

        if (Input.GetKeyDown(KeyCode.B))
            KillSpecificEnemies(enemies[0]);

    }
    /// <summary>
    /// Spawns enemies at spawn point
    /// </summary>
    void SpawnEnemy()
    {
        
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            int rnd = Random.Range(0, enemyTypes.Length);
            GameObject go = Instantiate(enemyTypes[rnd], spawnPoints[0].position, spawnPoints[0].rotation);
            enemies.Add(go);
        }
    }

    void KillSpecificEnemies()
    {
        int eCount = enemies.Count;
        for (int i = 0; i < enemies.Count; i++)
        {
            if (enemies[i].name.Contains(_condition))
                KillEnemy("_B");
        }
    }
    /// <summary>
    /// kill all enemies in the scene
    /// </summary>
    void KillAllEnemies()
    {
        int eCount = enemies.Count;
        for (int i = 0;  i < enemies.Count; i++)
        {
            KillEnemy(enemies[1]);
        }
    }
    /// <summary>
    /// Kills an enemy based off the GameObject passed in
    /// </summary>
    /// <param name="_enemy"></param>
    void KillEnemy(GameObject _enemy)
    {
        if (enemies.Count == 0)
            return;

        Destroy(_enemy);
        enemies.Remove(_enemy);
    }
}

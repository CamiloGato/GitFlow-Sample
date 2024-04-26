using System;
using Enemy;
using UnityEngine;

public class GameInstaller : MonoBehaviour
{
    [Header("Requirements")]
    public int id;
    public Transform position;
    
    [Header("Factories Configs")]
    public EnemyFactoryConfig config;

    private EnemyFactory _enemyFactory;

    private void Awake()
    {
        _enemyFactory = new EnemyFactory(config);
    }

    private void Start()
    {
        EnemyController player = _enemyFactory.Create(id); // 0 0 0
        EnemyController enemy = _enemyFactory.Create(Contra(id)); // 0 0 0

        player.transform.position = position.position; // Position
        enemy.transform.position = position.position + new Vector3(1, 0, 1); // Position + 1 0 1

    }

    public int Contra(int id) => (id + 2) % 4;
}
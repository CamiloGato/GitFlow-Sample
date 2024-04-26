using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    [CreateAssetMenu(fileName = "Enemy", menuName = "Container", order = 0)]
    public class EnemyFactoryConfig : ScriptableObject
    {
        public List<EnemyController> prefabs;

        public EnemyController GetPrefab(int id)
        {
            return prefabs.Find(enemy => enemy.id == id);
        }
    }
}
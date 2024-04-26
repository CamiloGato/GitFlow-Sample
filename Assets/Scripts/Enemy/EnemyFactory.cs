namespace Enemy
{
    public class EnemyFactory
    {
        private readonly EnemyFactoryConfig _config;

        public EnemyFactory(EnemyFactoryConfig config)
        {
            _config = config;
        }

        public EnemyController Create(int id)
        {
            EnemyController prefabToCreate = _config.GetPrefab(id);
            return UnityEngine.Object.Instantiate(prefabToCreate);
        }
        
    }
}
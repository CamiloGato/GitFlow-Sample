using Destructor;
using Entity;
using UnityEngine;

namespace Enemy
{
    public class EnemyController : EntityController, IDestructor
    {
        public int id;
        [SerializeField] private int lifes;
        
        public void Destroy()
        {
            lifes--;
            
            if (lifes <= 0)
            {
                UnityEngine.Object.Destroy(gameObject);
            }
        }
    }
}
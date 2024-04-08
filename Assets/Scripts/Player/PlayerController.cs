using Destructor;
using Entity;
using UnityEngine;

namespace Player
{
    public class PlayerController : EntityController, IDestructor
    {
        [SerializeField] private float multiply;
        
        public void Destroy()
        {
            Rb.AddForce(Vector3.back * multiply, ForceMode.Impulse);
        }
    }
}
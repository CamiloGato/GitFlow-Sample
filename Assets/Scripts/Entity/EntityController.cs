using UnityEngine;

namespace Entity
{
    [RequireComponent(typeof(Rigidbody))]
    public abstract class EntityController : MonoBehaviour
    {
        protected Rigidbody Rb;

        private void Awake()
        {
            Rb = GetComponent<Rigidbody>();
        }
    }
}
using System;
using Destructor;
using UnityEngine;

namespace Armas
{
    [RequireComponent(typeof(Rigidbody))]
    public class Granada : MonoBehaviour
    {
        public float radius;

        private void Explode()
        {
            Collider[] colliders = new Collider[5];
            
            int amount = Physics.OverlapSphereNonAlloc(transform.position, radius, colliders);

            foreach (Collider colliderDetected in colliders)
            {
                if(!colliderDetected) continue;
                
                colliderDetected.gameObject.TryGetComponent<IDestructor>(out IDestructor component);
                component?.Destroy();
            }
            
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Explode();
            }
        }
    }
}
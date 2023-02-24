using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JumpSpace.Movements
{
    public class Mover
    {
        private Rigidbody _rigidbody;
        private float _force = 20;

        public Mover(Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;
        }

        public void FixedTick()
        {
            _rigidbody.AddForce(Vector3.up *(Time.deltaTime * _force),ForceMode.Impulse);
        }
        
    }
}


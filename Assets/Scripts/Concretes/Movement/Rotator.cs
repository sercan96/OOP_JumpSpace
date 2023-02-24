using System.Collections;
using System.Collections.Generic;
using JumpSpace.Controllers;
using UnityEngine;

namespace JumpSpace.Movements
{
    public class Rotator
    {
        private PlayerController _playerController;
        private Rigidbody _rigidbody;
        
        public Rotator(PlayerController playerController)
        {
            _playerController = playerController;
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick(float direction)
        {
            if (direction == 0)
            {
                if (_rigidbody.freezeRotation) _rigidbody.freezeRotation = false;
                return;
            }
            
            if (!_rigidbody.freezeRotation) _rigidbody.freezeRotation = true;
            _playerController.transform.Rotate(Vector3.right * (direction * _playerController.TurnSpeed * Time.deltaTime));
        }
    }
}


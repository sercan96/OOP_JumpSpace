using System;
using System.Collections;
using System.Collections.Generic;
using JumpSpace.Inputs;
using JumpSpace.Movements;
using UnityEngine;

namespace JumpSpace.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float force;
        public bool isForceUp;
        
        private Rigidbody _rigidbody;
        private DefaultInput _input;
        private Mover _mover;
   

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _input = new DefaultInput();
            _mover = new Mover(_rigidbody);
        }

        private void Update()
        {
            if (_input.isForceUp)
                isForceUp = true;
            else
                isForceUp = false;
            
            //isForceUp = _input.isForceUp;
        }
        
        private void FixedUpdate()
        {
            if (isForceUp)
            {
                // _rigidbody.AddForce(Vector3.up * (Time.deltaTime * force),ForceMode.Impulse);
                _mover.FixedTick();
            }
        }

   
    }
}


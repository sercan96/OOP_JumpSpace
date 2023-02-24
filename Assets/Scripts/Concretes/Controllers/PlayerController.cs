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
        [SerializeField] private float turnSpeed;

        public float Force => force;
        public float TurnSpeed => turnSpeed;

        private float _leftRight;
        
        public bool isForceUp;
        
        private Rigidbody _rigidbody;
        
        private DefaultInput _input;
        private Mover _mover;
        private Rotator _rotator;
   

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
        }

        private void Update()
        {
            if (_input.isForceUp)
                isForceUp = true;
            else
                isForceUp = false;

            _leftRight = _input._leftRight;

            //isForceUp = _input.isForceUp;
        }
        
        private void FixedUpdate()
        {
            if (isForceUp)
            {
                _mover.FixedTick();
            }
            _rotator.FixedTick(_leftRight);
        }
    }
}


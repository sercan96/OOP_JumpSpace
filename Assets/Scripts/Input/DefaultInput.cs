using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JumpSpace.Inputs
{
    public class DefaultInput 
    {
        public bool isForceUp { get; private set; }
        public float _leftRight;
        
        private DefaultAction _input;
        
        public DefaultInput()
        {
            _input = new DefaultAction();
            _input.Rocket.ForceUp.performed += context => isForceUp = context.ReadValueAsButton();
            _input.Rocket.LeftRight.performed += context => _leftRight = context.ReadValue<float>();
            
            _input.Enable();
        }
    }

}

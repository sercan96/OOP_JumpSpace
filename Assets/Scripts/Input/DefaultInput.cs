using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JumpSpace.Inputs
{
    public class DefaultInput 
    {
        public bool isForceUp { get; private set; }
        
        private DefaultAction _input;
        
        public DefaultInput()
        {
            _input = new DefaultAction();
            _input.Rocket.ForceUp.performed += context => isForceUp = context.ReadValueAsButton();
            _input.Enable();
        }
    }

}

using System;
using UnityEngine;

namespace QulisoftTestTask.Player
{
    public class PlayerKeyboardInput : MonoBehaviour, IPlayerInput
    {
        public event Action<bool> IsAccelerating;
        public event Action<bool> IsBraking;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
                IsAccelerating?.Invoke(true);
            
            else if (Input.GetKeyDown(KeyCode.A))
                IsBraking?.Invoke(true);
        }
    }
}
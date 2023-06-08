using System;
using UnityEngine;

namespace QulisoftTestTask.Player.Input
{
    public abstract class PlayerInput : MonoBehaviour
    {
        public event Action<bool> IsMovingForward;
        
        protected void MoveForward()
        {
            IsMovingForward?.Invoke(true);
        }
        
        protected void MoveBackward()
        {
            IsMovingForward?.Invoke(false);
        }
    }
}

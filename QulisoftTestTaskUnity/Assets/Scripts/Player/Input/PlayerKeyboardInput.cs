using UnityEngine;

namespace QulisoftTestTask.Player.Input
{
    public class PlayerKeyboardInput : PlayerInput
    {
        private void Update()
        {
            if (UnityEngine.Input.GetKey(KeyCode.D))
                MoveForward();
            
            else if (UnityEngine.Input.GetKey(KeyCode.A))
                MoveBackward();
        }
    }
}
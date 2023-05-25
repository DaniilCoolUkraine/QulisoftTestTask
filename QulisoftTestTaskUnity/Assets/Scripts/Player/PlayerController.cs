using QulisoftTestTask.Player.Input;
using UnityEngine;

namespace QulisoftTestTask.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerInput _playerInput;
        [SerializeField] private PlayerMovement _playerMovement;

        private void OnEnable()
        {
            _playerInput.IsMovingForward += _playerMovement.Move;
        }
        
        private void OnDisable()
        {
            _playerInput.IsMovingForward -= _playerMovement.Move;
        }
    }
}
using QulisoftTestTask.Player.Input;
using QulisoftTestTask.ScriptableObjects.Events;
using UnityEngine;

namespace QulisoftTestTask.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private BoolEventSO _onAccelerateButtonIsHolding;
        [SerializeField] private BoolEventSO _onBrakeButtonIsHolding;
        
        [SerializeField] private PlayerInput[] _playerInputs;
        [SerializeField] private PlayerMovement _playerMovement;

        private void OnEnable()
        {
            _onAccelerateButtonIsHolding.OnValueChanged += _playerMovement.Move;
            _onBrakeButtonIsHolding.OnValueChanged += _playerMovement.Move;
            
            foreach (PlayerInput playerInput in _playerInputs)
            {
                playerInput.IsMovingForward += _playerMovement.Move;
            }
        }
        
        private void OnDisable()
        {
            _onAccelerateButtonIsHolding.OnValueChanged -= _playerMovement.Move;
            _onBrakeButtonIsHolding.OnValueChanged -= _playerMovement.Move;
            
            foreach (PlayerInput playerInput in _playerInputs)
            {
                playerInput.IsMovingForward -= _playerMovement.Move;
            }
        }
    }
}
using UnityEngine;
using UnityEngine.UI;

namespace QulisoftTestTask.Player.Input
{
    public class PlayerUiInput : PlayerInput
    {
        [SerializeField] private Button _accelerateButton;
        [SerializeField] private Button _brakeButton;

        private void OnEnable()
        {
            _accelerateButton.onClick.AddListener(MoveForward);
            _brakeButton.onClick.AddListener(MoveBackward);
        }

        private void OnDisable()
        {
            _accelerateButton.onClick.RemoveListener(MoveForward);
            _brakeButton.onClick.RemoveListener(MoveBackward);
        }
    }
}
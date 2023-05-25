using System;
using UnityEngine;
using UnityEngine.UI;

namespace QulisoftTestTask.Player
{
    public class PlayerUiInput : MonoBehaviour, IPlayerInput
    {
        public event Action<bool> IsAccelerating;
        public event Action<bool> IsBraking;

        [SerializeField] private Button _accelerateButton;
        [SerializeField] private Button _brakeButton;

        private void OnEnable()
        {
            _accelerateButton.onClick.AddListener(Accelerate);
            _brakeButton.onClick.AddListener(Brake);
        }

        private void OnDisable()
        {
            _accelerateButton.onClick.RemoveListener(Accelerate);
            _brakeButton.onClick.RemoveListener(Brake);
        }

        private void Accelerate()
        {
            IsAccelerating?.Invoke(true);
        }

        private void Brake()
        {
            IsBraking?.Invoke(true);
        }
    }
}
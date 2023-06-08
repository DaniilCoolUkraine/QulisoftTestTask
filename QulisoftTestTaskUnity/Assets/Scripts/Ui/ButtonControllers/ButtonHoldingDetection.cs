using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace QulisoftTestTask.Ui.ButtonControllers
{
    public class ButtonHoldingDetection : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        public event Action<bool> OnButtonIsHolding;

        [SerializeField] private bool _isForward;

        private bool _isHolding = false;

        private void Update()
        {
            if (_isHolding)
                OnButtonIsHolding?.Invoke(_isForward);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            _isHolding = true;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            _isHolding = false;
        }
    }
}
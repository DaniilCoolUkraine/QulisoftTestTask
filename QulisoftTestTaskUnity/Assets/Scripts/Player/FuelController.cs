using QulisoftTestTask.ScriptableObjects.Events;
using UnityEngine;

namespace QulisoftTestTask.Player
{
    public class FuelController : MonoBehaviour
    {
        [SerializeField] private FloatEventSO _fuelAmountChanged;
        [SerializeField] private EventSO _onFuelEnded;

        [SerializeField] private float _drainSpeed;

        private float _maxFuelAmount = 100f;

        private float _currentFuelAmount;

        private float CurrentFuelAmount
        {
            get => _currentFuelAmount;
            set
            {
                _currentFuelAmount = value;
                _fuelAmountChanged.ChangeValue(_currentFuelAmount / _maxFuelAmount);

                if (value <= 0)
                {
                    _onFuelEnded.Invoke();
                }
            }
        }

        private void Start()
        {
            CurrentFuelAmount = _maxFuelAmount;
        }

        private void Update()
        {
            if (CurrentFuelAmount <= 0)
                return;

            CurrentFuelAmount -= _drainSpeed * Time.deltaTime;
        }
    }
}
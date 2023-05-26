using QulisoftTestTask.ScriptableObjects.Events;
using UnityEngine;

namespace QulisoftTestTask.Player
{
    public class FuelController : MonoBehaviour
    {
        [SerializeField] private FloatEventSO _fuelAmountChanged;
        
        [SerializeField] private float _drainSpeed;
        
        private float _maxFuelAmount = 100f;
        
        private float _currentFuelAmount;
        private float CurrentFuelAmount
        {
            get => _currentFuelAmount;
            set
            {
                _currentFuelAmount = value;
                _fuelAmountChanged.ChangeValue(_currentFuelAmount/_maxFuelAmount);
            }
        }

        private void Start()
        {
            CurrentFuelAmount = _maxFuelAmount;
        }

        private void Update()
        {
            CurrentFuelAmount -= _drainSpeed * Time.deltaTime;
        }
    }
}
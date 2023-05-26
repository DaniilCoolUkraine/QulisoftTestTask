using QulisoftTestTask.ScriptableObjects.Events;
using UnityEngine;

namespace QulisoftTestTask.Ui
{
    public class UiManager : MonoBehaviour
    {
        [Header("Events")]
        [SerializeField] private FloatEventSO _fuelAmountChanged;

        [Header("Components")] 
        [SerializeField] private UiFuelShower _uiFuelShower;

        private void OnEnable()
        {
            _fuelAmountChanged.OnValueChanged += _uiFuelShower.UpdateFuelFill;
        }
        
        private void OnDisable()
        {
            _fuelAmountChanged.OnValueChanged -= _uiFuelShower.UpdateFuelFill;
        }
    }
}
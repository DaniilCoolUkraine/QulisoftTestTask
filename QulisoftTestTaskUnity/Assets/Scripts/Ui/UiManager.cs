using QulisoftTestTask.ScriptableObjects.Events;
using QulisoftTestTask.Ui.ButtonControllers;
using UnityEngine;

namespace QulisoftTestTask.Ui
{
    public class UiManager : MonoBehaviour
    {
        [Header("Events")]
        [SerializeField] private FloatEventSO _fuelAmountChanged;
        [SerializeField] private EventSO _onPlayerLoose;
        
        [SerializeField] private BoolEventSO _onAccelerateButtonIsHolding;
        [SerializeField] private BoolEventSO _onBrakeButtonIsHolding;
        
        [Header("Components")] 
        [SerializeField] private UiFuelShower _uiFuelShower;
        [SerializeField] private ScreenController _looseScreenController;

        [SerializeField] private ButtonHoldingDetection _accelerateButtonIsHolding;
        [SerializeField] private ButtonHoldingDetection _brakeButtonIsHolding;

        private void OnEnable()
        {
            _fuelAmountChanged.OnValueChanged += _uiFuelShower.UpdateFuelFill;
            _onPlayerLoose.OnInvoked += _looseScreenController.SwitchScreen;

            _accelerateButtonIsHolding.OnButtonIsHolding += _onAccelerateButtonIsHolding.ChangeValue;
            _brakeButtonIsHolding.OnButtonIsHolding += _onBrakeButtonIsHolding.ChangeValue;
        }
        
        private void OnDisable()
        {
            _fuelAmountChanged.OnValueChanged -= _uiFuelShower.UpdateFuelFill;
            _onPlayerLoose.OnInvoked -= _looseScreenController.SwitchScreen;
            
            _accelerateButtonIsHolding.OnButtonIsHolding -= _onAccelerateButtonIsHolding.ChangeValue;
            _brakeButtonIsHolding.OnButtonIsHolding -= _onBrakeButtonIsHolding.ChangeValue;
        }
    }
}
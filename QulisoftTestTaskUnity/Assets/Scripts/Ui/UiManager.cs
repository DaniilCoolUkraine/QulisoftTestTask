using QulisoftTestTask.ScriptableObjects.Events;
using UnityEngine;

namespace QulisoftTestTask.Ui
{
    public class UiManager : MonoBehaviour
    {
        [Header("Events")]
        [SerializeField] private FloatEventSO _fuelAmountChanged;
        [SerializeField] private EventSO _onPlayerLoose;

        [Header("Components")] 
        [SerializeField] private UiFuelShower _uiFuelShower;
        [SerializeField] private ScreenController _looseScreenController;

        private void OnEnable()
        {
            _fuelAmountChanged.OnValueChanged += _uiFuelShower.UpdateFuelFill;
            _onPlayerLoose.OnInvoked += _looseScreenController.SwitchScreen;
        }
        
        private void OnDisable()
        {
            _fuelAmountChanged.OnValueChanged -= _uiFuelShower.UpdateFuelFill;
            _onPlayerLoose.OnInvoked -= _looseScreenController.SwitchScreen;
        }
    }
}
using UnityEngine;
using UnityEngine.UI;

namespace QulisoftTestTask.Ui
{
    public class UiFuelShower : MonoBehaviour
    {
        [SerializeField] private Image _fuelFillImage;
        [SerializeField] private Gradient _fillGradient;

        public void UpdateFuelFill(float value)
        {
            _fuelFillImage.fillAmount = value;
            _fuelFillImage.color = _fillGradient.Evaluate(value);
        }
    }
}
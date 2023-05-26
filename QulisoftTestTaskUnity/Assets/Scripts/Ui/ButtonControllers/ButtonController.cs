using UnityEngine;
using UnityEngine.UI;

namespace QulisoftTestTask.Ui.ButtonControllers
{
    public abstract class ButtonController : MonoBehaviour
    {
        [SerializeField] private Button _button;

        private void OnEnable()
        {
            _button.onClick.AddListener(DoAction);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(DoAction);
        }

        protected abstract void DoAction();
    }
}
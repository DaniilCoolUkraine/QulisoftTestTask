using UnityEngine;

namespace QulisoftTestTask.Ui
{
    public class ScreenController : MonoBehaviour
    {
        [SerializeField] private GameObject _screen;

        private void OnEnable()
        {
            Time.timeScale = 0;
        }

        private void OnDisable()
        {
            Time.timeScale = 1;
        }

        public void SwitchScreen()
        {
            _screen.SetActive(!_screen.activeSelf);
        }
    }
}
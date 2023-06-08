using System;
using UnityEngine;

namespace QulisoftTestTask.ScriptableObjects.Events
{
    [CreateAssetMenu(fileName = "BoolEventSO", menuName = "ScriptableObjects/BoolEventSO", order = 0)]
    public class BoolEventSO : ScriptableObject
    {
        public event Action<bool> OnValueChanged;

        public void ChangeValue(bool value)
        {
            OnValueChanged?.Invoke(value);
        }
    }
}
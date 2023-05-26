using System;
using UnityEngine;

namespace QulisoftTestTask.ScriptableObjects.Events
{
    [CreateAssetMenu(fileName = "FloatEventSO", menuName = "ScriptableObjects/FloatEventSO", order = 0)]
    public class FloatEventSO : ScriptableObject
    {
        public event Action<float> OnValueChanged;

        public void ChangeValue(float value)
        {
            OnValueChanged?.Invoke(value);
        }
    }
}
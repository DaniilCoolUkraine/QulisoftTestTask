﻿using System;
using UnityEngine;

namespace QulisoftTestTask.ScriptableObjects.Events
{
    [CreateAssetMenu(fileName = "EventSO", menuName = "ScriptableObjects/EventSO", order = 0)]
    public class EventSO : ScriptableObject
    {
        public event Action OnInvoked;

        public void Invoke()
        {
            OnInvoked?.Invoke();
        }
    }
}
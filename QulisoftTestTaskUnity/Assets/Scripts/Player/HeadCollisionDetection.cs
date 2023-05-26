using System;
using QulisoftTestTask.ScriptableObjects.Events;
using UnityEngine;

namespace QulisoftTestTask.Player
{
    public class HeadCollisionDetection : MonoBehaviour
    {
        [SerializeField] private EventSO _onPlayerLoose;
        
        private void OnCollisionEnter2D(Collision2D col)
        {
            if (col.collider.CompareTag("Ground"))
            {
                _onPlayerLoose.Invoke();
            }
        }
    }
}
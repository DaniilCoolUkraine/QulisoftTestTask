using QulisoftTestTask.Player;
using UnityEngine;

namespace QulisoftTestTask.Collectables
{
    public abstract class Collectable : MonoBehaviour
    {
        protected ICollector _collector;
        
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                col.TryGetComponent<ICollector>(out _collector); 
                Collect();
            }
        }

        protected abstract void Collect();
    }
}
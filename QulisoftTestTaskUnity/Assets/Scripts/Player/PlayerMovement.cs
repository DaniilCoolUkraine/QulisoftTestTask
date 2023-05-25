using UnityEngine;

namespace QulisoftTestTask.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _wholeCar;
        
        [SerializeField] private Rigidbody2D _frontWheel;
        [SerializeField] private Rigidbody2D _backWheel;

        [SerializeField] private float _speed;
        [SerializeField] private float _rotationSpeed;
        
        public void Move(bool isMovingForward)
        {
            int direction = isMovingForward ? 1 : -1;

            _frontWheel.AddTorque(-direction * _speed * Time.fixedDeltaTime);
            _backWheel.AddTorque(-direction * _speed * Time.fixedDeltaTime);
            _wholeCar.AddTorque(-direction * _rotationSpeed * Time.fixedDeltaTime);
        }
    }
}
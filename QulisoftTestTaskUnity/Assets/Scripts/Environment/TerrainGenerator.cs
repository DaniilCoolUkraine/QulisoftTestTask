using UnityEngine;
using UnityEngine.U2D;

namespace QulisoftTestTask.Environment
{
    [ExecuteInEditMode]
    public class TerrainGenerator : MonoBehaviour
    {
        [SerializeField] private SpriteShapeController _spriteShapeController;
        [SerializeField] private int _levelLength;

        [SerializeField] private Vector2 _axisMultiplier;
        [SerializeField] private float _curveSmoothness;

        [SerializeField] private float _noiseStep;

        [SerializeField] private float _levelBottom;

        private Vector3 _lastPointPosition;
        
        private void OnValidate()
        {
            _spriteShapeController.spline.Clear();

            for (int i = 0; i < _levelLength; i++)
            {
                _lastPointPosition = transform.position + new Vector3(i * _axisMultiplier.x, Mathf.PerlinNoise(0, i * _noiseStep) * _axisMultiplier.y);
                _spriteShapeController.spline.InsertPointAt(i, _lastPointPosition);

                if (i != 0 && i != (_levelLength - 1))
                {
                    _spriteShapeController.spline.SetTangentMode(i, ShapeTangentMode.Continuous);

                    _spriteShapeController.spline.SetLeftTangent(i, Vector3.left * _axisMultiplier.x * _curveSmoothness);
                    _spriteShapeController.spline.SetRightTangent(i, Vector3.right * _axisMultiplier.x * _curveSmoothness);
                }
            }

            _spriteShapeController.spline.InsertPointAt(_levelLength, new Vector3(_lastPointPosition.x, transform.position.y - _levelBottom));
            _spriteShapeController.spline.InsertPointAt(_levelLength + 1, new Vector3(transform.position.x, transform.position.y - _levelBottom));
        }
    }
}
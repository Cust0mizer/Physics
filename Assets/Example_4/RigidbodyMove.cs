using UnityEngine;

namespace Assets.Example_4 {
    public class RigidbodyMove : MonoBehaviour {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _rotationSpeed;
        [SerializeField] private float _force;

        private float _horizontal;
        private float _vertical;
        private float _cameraDiretion;

        private void Update() {
            _horizontal = Input.GetAxis("Horizontal");
            _vertical = Input.GetAxis("Vertical");
            _cameraDiretion = Input.GetAxis("Mouse X");
        }

        private void FixedUpdate() {
            Vector3 velocity = new Vector3(_horizontal, _rigidbody.velocity.y, _vertical) * _force;
            Vector3 vorldVelosity = transform.TransformVector(velocity);
            _rigidbody.velocity = vorldVelosity;
            transform.Rotate(0, _cameraDiretion * _rotationSpeed, 0);
        }
    }
}
using UnityEngine;

namespace Assets.Example_5 {
    public class RigidbodyMove : MonoBehaviour {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _rotationSpeed;
        [SerializeField] private float _force;

        private float _horizontal;
        private float _vertical;
        private float _cameraDiretion;

        private void Start() {
            //_rigidbody.centerOfMass = new Vector3(0, 1, 0);
        }

        private void Update() {

        }

        private void FixedUpdate() {
            _horizontal = Input.GetAxis("Horizontal");
            _vertical = Input.GetAxis("Vertical");
            _cameraDiretion = Input.GetAxis("Mouse X");

            Vector3 velocity = new Vector3(_horizontal, _rigidbody.velocity.y, _vertical) * _force;
            Vector3 vorldVelosity = transform.TransformVector(velocity);
            _rigidbody.velocity = vorldVelosity;
            _rigidbody.angularVelocity = new Vector3(0f, _cameraDiretion * _rotationSpeed, 0f);
        }
    }
}
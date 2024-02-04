using UnityEngine;

namespace Assets.Example_3 {
    public class RigidbodyMove : MonoBehaviour {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _rotationSpeed;
        [SerializeField] private float _force;

        private void FixedUpdate() {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            float cameraDiretion = Input.GetAxis("Mouse X");

            Vector3 force = new Vector3(horizontal, 0, vertical) * _force;
            _rigidbody.AddRelativeForce(force);
            transform.Rotate(0, cameraDiretion * _rotationSpeed, 0);
        }
    }
}

//Причины не использовать AddRelativeForce
//Менять Drag (Плохое падение)
//Менять добавлять физический материал - проблемы с стенами

using UnityEngine;

namespace Assets.Example_1 {
    public class TransformMove : MonoBehaviour {
        [SerializeField] private float _speedMove = 3f;
        [SerializeField] private float _rotationSensitivity = 10f;

        private void Update() {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            float cameraDiretion = Input.GetAxis("Mouse X");

            Vector3 offset = new Vector3(horizontal, 0f, vertical) * Time.deltaTime * _speedMove;
            transform.Translate(offset);
            transform.Rotate(0f, cameraDiretion * _rotationSensitivity, 0f);
        }
    }
}
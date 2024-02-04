using UnityEngine;

public class PhisicsRotateComponent : MonoBehaviour {
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speedRotate = 5;

    public void UpdateRotation(float mouseY) {
        _rigidbody.angularVelocity = new Vector3(0f, mouseY * _speedRotate, 0f);
    }
}
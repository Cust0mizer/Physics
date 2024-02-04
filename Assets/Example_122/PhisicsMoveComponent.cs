using System;
using UnityEngine;

public class PhisicsMoveComponent : MonoBehaviour {
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speedMove = 10;
    [SerializeField] private float _jumpForce = 10;

    public void UpdatePosition(Vector3 direction) {
        Vector3 relativeVector = transform.TransformVector(direction);
        var newDiretion = new Vector3(relativeVector.x * _speedMove, _rigidbody.velocity.y, relativeVector.z * _speedMove);
        _rigidbody.velocity = newDiretion;
    }

    public void Jump() {
        _rigidbody.AddForce(new Vector3(0, _jumpForce, 0), ForceMode.VelocityChange);
    }
}

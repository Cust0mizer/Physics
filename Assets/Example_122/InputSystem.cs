using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InputSystem : MonoBehaviour {
    public event Action<float> OnMouseDirectionUpdate;
    public event Action<Vector3> OnMoveDirectionUpdate;
    public Action<float> OnRotate;
    public event Action OnJump;

    private float _horizontal;
    private float _vertical;
    private float _mouseX;
    private float _mouseY;

    private void Update() {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
        _mouseX = Input.GetAxis("Mouse X");
        _mouseY -= Input.GetAxis("Mouse Y");

        if (Input.GetKeyDown(KeyCode.Space)) {
            OnJump?.Invoke();
        }
    }

    private void LateUpdate() {
        //if (_mouseY != 0) {
        //    OnMouseDirectionUpdate?.Invoke(_mouseY);
        //}
        OnRotate?.Invoke(_mouseX);
    }

    private void FixedUpdate() {
        if (_horizontal != 0 || _vertical != 0) {
            Vector3 moveDirection = new Vector3(_horizontal, 0, _vertical);
            OnMoveDirectionUpdate?.Invoke(moveDirection);
        }
    }
}

using UnityEngine;

public class InputObserver : MonoBehaviour {
    [SerializeField] PhisicsRotateComponent _phisicsRotateComponent;
    [SerializeField] PhisicsMoveComponent _phisicsMoveComponent;
    [SerializeField] private InputSystem _inputSystem;
    [SerializeField] private CameraMover _cameraMover;

    private void Start() {
        _inputSystem.OnMouseDirectionUpdate += OnCameraUpdate;
        _inputSystem.OnMoveDirectionUpdate += UpdatePosition;
        _inputSystem.OnRotate += Rotation;
        _inputSystem.OnJump += Jump;
    }

    private void Jump() {
        _phisicsMoveComponent.Jump();
    }

    private void UpdatePosition(Vector3 direction) {
        _phisicsMoveComponent.UpdatePosition(direction);
    }

    private void Rotation(float mouseY) {
        _phisicsRotateComponent.UpdateRotation(mouseY);
    }

    private void OnCameraUpdate(float mouseX) {
        _cameraMover.CameraPositionUpdate(mouseX);
    }

    private void OnDestroy() {
        _inputSystem.OnMoveDirectionUpdate -= UpdatePosition;
        _inputSystem.OnJump -= Jump;
    }
}

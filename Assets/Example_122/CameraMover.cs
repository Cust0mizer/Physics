using UnityEngine;

public class CameraMover : MonoBehaviour {
    [SerializeField] private Camera _camera;
    [SerializeField] private float _minPosition = 20;
    [SerializeField] private float _maxPosition = 33;

    public void CameraPositionUpdate(float mouseX) {
        mouseX = Mathf.Clamp(mouseX, _minPosition, _maxPosition);
        _camera.transform.localEulerAngles = new Vector3(mouseX, 0f, 0f);
    }
}
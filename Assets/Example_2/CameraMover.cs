using UnityEngine;

namespace Assets.Example_2 {
    [DefaultExecutionOrder(-1000)]
    public class CameraMover : MonoBehaviour {
        [SerializeField] private Transform _target;

        private void LateUpdate() {
            transform.position = _target.position;
        }
    }
}
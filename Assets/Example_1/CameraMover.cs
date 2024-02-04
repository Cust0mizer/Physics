using UnityEngine;

namespace Assets.Example_1 {
[DefaultExecutionOrder(-1000)]
    public class CameraMover : MonoBehaviour {
        [SerializeField] private Transform _target;

        private void Update() {
            transform.position = _target.position;
        }
    }
}
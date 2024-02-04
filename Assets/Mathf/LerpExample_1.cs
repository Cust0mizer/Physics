using UnityEngine;

[ExecuteAlways]
public class LerpExample_1 : MonoBehaviour {
    [SerializeField] private float _min;
    [SerializeField] private float _max;
    [SerializeField, Range(0, 1)] private float _time;


    private void Update() {
        transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, _min, 0), Quaternion.Euler(0, _max, 0), _time);
        //_time += Time.deltaTime / 10;
        //print(Time.time);
    }
}

//Попутно рассказать про корутины.
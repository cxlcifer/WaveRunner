using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMoving : MonoBehaviour
{
    [SerializeField] private Vector3 _start;
    [SerializeField] private Vector3 _end;

    private float _currentTime;

    [SerializeField] private float _duration;
    // Update is called once per frame
    void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentTime, _duration) / _duration;
        transform.position = Vector3.Lerp(_start, _end, progress);
    }
}

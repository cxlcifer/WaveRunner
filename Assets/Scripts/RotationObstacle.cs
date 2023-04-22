using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RotationObstacle : MonoBehaviour
{
    [SerializeField] private Quaternion _startQuaternion;
    [SerializeField] private Quaternion _endQuaternion;
    [SerializeField] private float _duration;
    private float _currentTime;
    
    // Update is called once per frame
    void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentTime, _duration) / _duration;
        transform.rotation = Quaternion.Lerp(_startQuaternion, _endQuaternion, progress);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMoving : MonoBehaviour
{
    [SerializeField] private Vector3 _leftBorder;
    [SerializeField] private Vector3 _rightBorder;
    [SerializeField] private float _duration;
    
    private float _currentTime;
 
    void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentTime, _duration) / _duration;

        var position = Vector3.Lerp(_leftBorder, _rightBorder, progress);
        transform.position = position;
    }
}

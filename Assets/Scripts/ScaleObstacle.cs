using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObstacle : MonoBehaviour
{
   [SerializeField] private Vector3 _minScale;
   [SerializeField] private Vector3 _maxScale;

    private float _currentTime;
    [SerializeField] private float _duration;
    
    // Update is called once per frame
    void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentTime, _duration) / _duration;
        transform.localScale = Vector3.Lerp(_minScale, _maxScale, progress);
    }
}

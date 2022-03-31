using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform _player;
    private Vector3 _tempPos;

    [SerializeField]
    private float minX, maxX;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        _tempPos = transform.position;
        _tempPos.x = _player.position.x;

        if( _tempPos.x < minX )
            _tempPos.x = minX;
        if( _tempPos.x > maxX )
            _tempPos.x = maxX;

        transform.position = _tempPos;
    }
}

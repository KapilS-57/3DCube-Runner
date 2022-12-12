using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followplayer : MonoBehaviour
{
    public Transform _playerTransform;
    public float _offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 _cameraPos = transform.position;
        _cameraPos.z = _playerTransform.position.z + _offset;
        transform.position = _cameraPos;
    }
}

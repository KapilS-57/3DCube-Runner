using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private float _force;
    [SerializeField]
    private float _speed;

    public Rigidbody _rigidbody;
    public float _maxX;
    public float _minX;

     
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = transform.position;
       // playerPos.x = Mathf.Clamp(playerPos.x,_minX,_maxX);
       // transform.position = playerPos;

        if (playerPos.x <_minX) 
        {
            playerPos.x = _minX;
        }

        if (playerPos.x > _maxX)
        {
            playerPos.x = _maxX;
        }
        transform.position = playerPos;

        if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D)) 
        {
            Debug.Log("Right Arrow Key is pressed.");

            transform.position = transform.position + new Vector3(_speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A))
        {
            Debug.Log("left Arrow Key is pressed.");

            transform.position = transform.position + new Vector3(-_speed * Time.deltaTime, 0, 0);
          //transform.position = transform.position - new Vector3(5f * Time.deltaTime, 0, 0);
        }
        //transform.position = transform.position + new Vector3(0, 0, 5f*Time.deltaTime);
    }
    private void FixedUpdate()
    {
        _rigidbody.AddForce(0, 0, _force * Time.deltaTime);
    }
}

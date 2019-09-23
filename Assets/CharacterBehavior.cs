using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehavior : MonoBehaviour
{
    public float speed;
    [SerializeField] private float _currentSpeed;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _currentSpeed = speed;
        else if (Input.GetKeyUp(KeyCode.Space))
            _currentSpeed = 0;

        transform.position += Vector3.right * _currentSpeed;
    }
}

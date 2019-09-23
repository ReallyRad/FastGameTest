using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckingBallBehavior : MonoBehaviour
{
    public float amplitude;
    public float speed;
    public float phase;

    [SerializeField] private Transform _pivot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var rotation = new Vector3();
        rotation.x = amplitude * Mathf.Sin(Time.time * speed + phase);
        _pivot.eulerAngles = rotation;
    }
}

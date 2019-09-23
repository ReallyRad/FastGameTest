using System.Collections;
using System.Collections.Generic;
using UnityEngine;    
public class CharacterBehavior : MonoBehaviour
{
    public float speed;
    [SerializeField] private float _currentSpeed;

    private UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter m_Character; // A reference to the ThirdPersonCharacter on the object
    private Vector3 m_Move;

    // Start is called before the first frame update
    void Start()
    {
        m_Character = GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter>();
    }

    // Fixed update is called in sync with physics
    private void FixedUpdate()
    {
        // pass all parameters to the character control script
        m_Character.Move(m_Move, false, false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _currentSpeed = speed;
        else if (Input.GetKeyUp(KeyCode.Space))
            _currentSpeed = 0;

        m_Move = Vector3.right * _currentSpeed;
    }

    public void ResetTransform(Transform resetTransform)
    {
        _currentSpeed = 0;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        transform.position = resetTransform.position;
        transform.rotation = resetTransform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "LevelEnd")
            LevelManager.instance.Reset();
    }
}

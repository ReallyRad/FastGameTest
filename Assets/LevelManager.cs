using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Transform initialTransform;

    [SerializeField] CharacterBehavior _player;

    public static LevelManager instance;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null) instance = this;
        _player = FindObjectOfType<CharacterBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            Reset();
    }

    public void Reset()
    {
        _player.ResetTransform(initialTransform);
    }
}

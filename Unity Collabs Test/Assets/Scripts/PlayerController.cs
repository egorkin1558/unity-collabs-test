using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    [SerializeField] public Joystick joystick;
    public float walk_speed = 5;

    private Rigidbody _rigidbody;


    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector2 joystick_move = new Vector2(joystick.Horizontal,joystick.Vertical) * walk_speed;
        _rigidbody.velocity = new Vector3(joystick_move.x, _rigidbody.velocity.y, joystick_move.y);
    }
}

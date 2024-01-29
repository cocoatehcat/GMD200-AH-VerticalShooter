using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    private Vector2 _input;
    [SerializeField] private Vector2 moveSpeed;
    [SerializeField] private float boundsLeft = -5;
    [SerializeField] private float boundsRight = 5;
    [SerializeField] private float boundsTop = -2f;
    [SerializeField] private float boundsBottom = -15f;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _input = new Vector2(x: Input.GetAxis("Horizontal"), y: Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        _rb.velocity = _input * moveSpeed;

        //Get Current Position
        Vector2 position = (Vector2)transform.position;
        //Limit the position
        position.x = Mathf.Clamp(value: position.x, min: boundsLeft, max: boundsRight);
        position.y = Mathf.Clamp(value: position.y, min: boundsBottom, max: boundsTop);
        //Set current position to bound
        transform.position = (Vector3)position;
    }
}

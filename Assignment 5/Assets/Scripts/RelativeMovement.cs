using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class RelativeMovement : MonoBehaviour
{
    [SerializeField] Transform _target;
    public float _rotSpeed = 15.0f;
    [SerializeField] private float _moveSpeed = 6.0f;
    private CharacterController _charController;
    [SerializeField] private float _jumpSpeed = 15.0f;
    [SerializeField] private float _gravity = -9.8f;
    [SerializeField] private float _terminalVelocity = -10.0f;
    [SerializeField] private float _minFall = -1.5f;
    [SerializeField] private float _pushForce = 3.0f;
    private float _vertSpeed;
    private ControllerColliderHit _contact;


    void Start()
    {
        _charController = GetComponent<CharacterController>();
        _vertSpeed = _minFall;
        
    }

    void Update()
    {
        Vector3 movement = Vector3.zero;
        float horInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");
        if (horInput != 0 || vertInput != 0)
        {
            Vector3 right = _target.right;
            Vector3 forward = Vector3.Cross(right, Vector3.up);
            movement = (right * horInput) + (forward *
            vertInput);
            movement *= _moveSpeed;
            movement = Vector3.ClampMagnitude(movement, _moveSpeed);
        }
        bool hitGround = false;
        RaycastHit hit;
        if (_vertSpeed < 0 &&
        Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            float check = (_charController.height +
            _charController.radius) / 1.9f;
            hitGround = hit.distance <= check;
        }
        if (hitGround)
        {
            if (Input.GetButtonDown("Jump"))
            {
                _vertSpeed = _jumpSpeed;
            }
            else
            {
                _vertSpeed = _minFall;
            }
        }
        else
        {
            _vertSpeed += _gravity * 5 * Time.deltaTime;
            if (_vertSpeed < _terminalVelocity)
            {
                _vertSpeed = _terminalVelocity;
            }
            if (_charController.isGrounded)
            {
                if (Vector3.Dot(movement, _contact.normal) < 0)
                {
                    movement = _contact.normal * _moveSpeed;
                }
                else
                {
                    movement += _contact.normal * _moveSpeed;
                }
            }
        }
        movement.y = _vertSpeed;
        movement *= Time.deltaTime;
        _charController.Move(movement);
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        _contact = hit;
        Rigidbody rb = hit.collider.attachedRigidbody;
        if (rb != null && !rb.isKinematic)
        {
            rb.velocity = hit.moveDirection * _pushForce;
        }
    }

}

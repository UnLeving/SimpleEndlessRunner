using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float movementSpeed = 5f;
        [SerializeField] private float horizontalSpeed = 5f;
        [SerializeField] private Rigidbody rb;
        [SerializeField] private GroundChecker groundChecker;
        
        private float _horizontalVelocity;
        private Keyboard _keyboard;

        private void Awake()
        {
            _keyboard = Keyboard.current;
        }

        private void Update()
        {
            //UpdateForwardMovement();

            CalculateHorizontalVelocity();
        }
        
        private void FixedUpdate()
        {
            UpdateForwardMovement();

            //CalculateHorizontalVelocity();
        }

        private void CalculateHorizontalVelocity()
        {
            _horizontalVelocity = _keyboard.dKey.isPressed ? horizontalSpeed : 
                _keyboard.aKey.isPressed ? -horizontalSpeed : 0f;
        }

        private void UpdateForwardMovement()
        {
            //transform.Translate(new Vector3(_horizontalVelocity, 0f, movementSpeed) * Time.deltaTime);
            
            rb.MovePosition(rb.position + new Vector3(_horizontalVelocity, 0f, movementSpeed) * Time.deltaTime);
        }

        private void DoJump()
        {
            
        }
    }
}
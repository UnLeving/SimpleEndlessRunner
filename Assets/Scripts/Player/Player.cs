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
        
        private float _horizontalVelocity;
        private Keyboard _keyboard;

        private void Awake()
        {
            _keyboard = Keyboard.current;
        }

        private void Update()
        {
            UpdateForwardMovement();
            
            _horizontalVelocity = _keyboard.dKey.isPressed ? horizontalSpeed : 
                _keyboard.aKey.isPressed ? -horizontalSpeed : 0f;

        }

        private void UpdateForwardMovement()
        {
            //transform.Translate(Vector3.forward * (movementSpeed * Time.deltaTime));
            
            transform.Translate(new Vector3(_horizontalVelocity, 0f, movementSpeed) * Time.deltaTime);
        }
        
        private void FixedUpdate()
        {
            //rb.AddForce(new Vector3(_horizontalVelocity, 0f, 0f), ForceMode.VelocityChange);
            
            //rb.MovePosition(rb.position + new Vector3(_horizontalVelocity, 0f, movementSpeed) * Time.fixedDeltaTime);;
        }
    }
}
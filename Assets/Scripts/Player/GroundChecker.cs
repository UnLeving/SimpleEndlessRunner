using UnityEngine;

namespace Player
{
    public class GroundChecker : MonoBehaviour
    {
        [SerializeField] private LayerMask groundMask;
        
        public bool IsGrounded => Physics.Raycast(transform.position, Vector3.down, 1f, groundMask);
    }
}
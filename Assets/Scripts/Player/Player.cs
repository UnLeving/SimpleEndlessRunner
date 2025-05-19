using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float movementSpeed = 5f;
    
        private void Update()
        {
            transform.Translate(Vector3.forward * (movementSpeed * Time.deltaTime));
        }
    }
}
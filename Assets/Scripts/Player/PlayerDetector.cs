using Ground;
using UnityEngine;

namespace Player
{
    public class PlayerDetector : MonoBehaviour
    {
        [SerializeField] private GroundTile groundTile;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                groundTile.Deactivate();
            }
        }
    }
}
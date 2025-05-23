using UnityEngine;

namespace Ground
{
    public class GroundTilePlayerDetector : MonoBehaviour
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
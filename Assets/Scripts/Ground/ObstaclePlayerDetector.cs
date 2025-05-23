using UnityEngine;

namespace Ground
{
    public class ObstaclePlayerDetector : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                other.GetComponent<Player.Player>().ObstacleHit();
            }
        }
    }
}
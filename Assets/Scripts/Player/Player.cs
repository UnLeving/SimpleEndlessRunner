using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
        public static event System.Action OnHitObstacle;
        
        public void ObstacleHit()
        {
            Debug.Log("Player hit obstacle");
            
            OnHitObstacle?.Invoke();
        }
    }
}
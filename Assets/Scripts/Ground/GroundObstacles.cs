using System;
using UnityEngine;

namespace Ground
{
    public class GroundObstacles : MonoBehaviour
    {
        [SerializeField] private GameObject[] obstacles;
        [SerializeField] private int maxObstacles = 5;

        private void Awake()
        {
            foreach (var obstacle in obstacles)
            {
                obstacle.SetActive(false);
            }
        }
        
        public void ShowObstacles(bool show)
        {
            if (show == false) return;
            
            var obstaclesOnGround = UnityEngine.Random.Range(0, maxObstacles);
            
            for (int i = 0; i < obstaclesOnGround; i++)
            {
                var obstacle = obstacles[UnityEngine.Random.Range(0, obstacles.Length)];
                obstacle.SetActive(true);
            }
        }
    }
}
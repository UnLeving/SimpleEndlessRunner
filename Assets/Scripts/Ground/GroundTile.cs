using UnityEngine;
using UnityEngine.Pool;
using System.Collections;

namespace Ground
{
    public class GroundTile : MonoBehaviour
    {
        [field: SerializeField] public Transform NextSpawnPointTransform { get; private set; }
        [SerializeField] private GroundObstacles groundObstacles;
        
        private IObjectPool<GroundTile> _objectPool;
        
        public IObjectPool<GroundTile> ObjectPool { set => _objectPool = value; }

        public void Deactivate()
        {
            StartCoroutine(DeactivateWithDelay());
        }
        
        private IEnumerator DeactivateWithDelay()
        {
            yield return new WaitForSeconds(1f);
            
            _objectPool.Release(this);
        }

        public void ShowObstacles(bool show)
        {
            groundObstacles.ShowObstacles(show);
        }
    }
}
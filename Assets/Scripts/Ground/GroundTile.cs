using UnityEngine;
using UnityEngine.Pool;

namespace Ground
{
    public class GroundTile : MonoBehaviour
    {
        [field: SerializeField] public Transform NextSpawnPointTransform { get; private set; }
        
        private IObjectPool<GroundTile> _objectPool;
        
        public IObjectPool<GroundTile> ObjectPool { set => _objectPool = value; }

        public void Deactivate()
        {
            _objectPool.Release(this);
        }
    }
}
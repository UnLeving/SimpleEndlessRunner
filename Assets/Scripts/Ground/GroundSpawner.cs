using System;
using UnityEngine;
using UnityEngine.Pool;

namespace Ground
{
    public class GroundSpawner : MonoBehaviour
    {
        public static GroundSpawner Instance { get; private set; }
        
        
        [SerializeField] private GroundTile groundTile;
        [SerializeField] private bool collectionCheck = true;
        [SerializeField] private int defaultCapacity = 20;
        [SerializeField] private int maxSize = 100;
        [SerializeField] private int startTileAmount = 5;
        
        private Vector3 _nextTilePosition;
        private IObjectPool<GroundTile> _objectPool;
        
        private void Awake()
        {
            Instance = this;

            _objectPool = new ObjectPool<GroundTile>(CreateTile,
                OnGetFromPool, OnReleaseToPool, OnDestroyPooledObject,
                collectionCheck, defaultCapacity, maxSize);
        }

        private void Start()
        {
            for (int i = 0; i < startTileAmount; i++)
            {
                _objectPool.Get();
            }
        }

        private GroundTile CreateTile()
        {
            var tile = Instantiate(groundTile, transform);
            tile.ObjectPool = _objectPool;
            
            return tile;
        }
        
        private void OnReleaseToPool(GroundTile pooledObject)
        {
            pooledObject.gameObject.SetActive(false);

            _objectPool.Get();
        }
        
        private void OnGetFromPool(GroundTile pooledObject)
        {
            pooledObject.transform.position = _nextTilePosition;
            pooledObject.gameObject.SetActive(true);
            
            _nextTilePosition = pooledObject.NextSpawnPointTransform.position;
        }
        
        private void OnDestroyPooledObject(GroundTile pooledObject)
        {
            Destroy(pooledObject.gameObject);
        }
    }
}
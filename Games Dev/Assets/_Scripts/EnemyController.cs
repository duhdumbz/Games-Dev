using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;
    [SerializeField]
    private int _enemyCount = 5;
    [SerializeField]
    private Transform _spawnTopLeft, _spawnTopRight, _spawnBottomLeft, _spawnBottomRight;
   void Start()
    {
        for(int i = 0; i < _enemyCount; i++)
        {
            SpawnEnemy();
        }
            
    }

    private void SpawnEnemy()
    {
        Vector3 spawnPosition = SelectRandomPosition();
        GameObject enemyObject = Instantiate(_enemyPrefab, spawnPosition, Quaternion.identity);
    }

    private Vector3 SelectRandomPosition()
    {
        Transform selectedTransform = null;
        int randomValue = Random.Range(0, 4);
        SpawnPointType spawnType = (SpawnPointType)randomValue;
        switch (spawnType)
        {
            case SpawnPointType.TopLeft:
                {
                    selectedTransform = _spawnTopLeft;
                    break;
                }
            case SpawnPointType.TopRight:
                {
                    selectedTransform = _spawnTopRight;
                    break;
                }
            case SpawnPointType.BottomLeft:
                {
                    selectedTransform = _spawnBottomLeft;
                    break;
                }
            case SpawnPointType.BottomRight:
                {
                    selectedTransform = _spawnBottomRight;
                    break;
                }
            default:
                {
                    selectedTransform = _spawnTopLeft;
                    break;
                }

        }

        return selectedTransform.position + (Vector3)Random.insideUnitCircle;
    }

    void Update()
    {
        
    }

    
}
public enum SpawnPointType
{
    TopLeft = 0,
    TopRight = 1,
    BottomLeft = 2,
    BottomRight = 3
}
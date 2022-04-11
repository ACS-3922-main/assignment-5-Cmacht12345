using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private GameObject _enemyPrefab2;
    private GameObject _enemy;
    private GameObject _enemy2;
    void Update()
    {
        if (_enemy == null)
        {
            _enemy = Instantiate(_enemyPrefab) as GameObject;
            _enemy.transform.position = new Vector3(0, 1, 4);
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);
        }
        if (_enemy2 == null)
        {
            _enemy2 = Instantiate(_enemyPrefab2) as GameObject;
            _enemy2.transform.position = new Vector3(0, 0.1f, 5);
            float angle = Random.Range(0, 360);
            _enemy2.transform.Rotate(0, angle, 0);
        }
    }
}

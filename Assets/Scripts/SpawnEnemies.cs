using System.Collections;
using System.Linq;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] private GameObject[] _spawners;
    [SerializeField] private GameObject[] _enemies;

    private int _maxEnemies;
    private int _numberOfSpawner;

    private void Start()
    {
        _maxEnemies = 12;
        _numberOfSpawner = 0;
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (_numberOfSpawner < _maxEnemies)
        {
            float timeForWait = 2;
            Instantiate(_enemies[Random.Range(0, _enemies.Count() - 1)], _spawners[_numberOfSpawner].transform.position, Quaternion.identity);
            _numberOfSpawner++;
            yield return new WaitForSeconds(timeForWait);
        }
    }
}

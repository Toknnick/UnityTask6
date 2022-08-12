using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class SpawnerOfEnemies : MonoBehaviour
{
    [SerializeField] private GameObject[] _spawnPoints;
    [SerializeField] private Enemy[] _prefabs;
    [SerializeField] private float _timeForWait;

    private int _maxEnemies;

    private void Start()
    {
        _maxEnemies = 12;
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var timer = new WaitForSeconds(_timeForWait);

        for (int i = 0; i < _maxEnemies; i++)
        {
            Instantiate(_prefabs[Random.Range(0, _prefabs.Count() - 1)], _spawnPoints[i].transform.position, Quaternion.identity);
            yield return timer;
        }
    }
}

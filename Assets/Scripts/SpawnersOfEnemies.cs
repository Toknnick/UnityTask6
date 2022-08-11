using System.Collections;
using System.Linq;
using UnityEngine;

public class SpawnersOfEnemies : MonoBehaviour
{
    [SerializeField] private GameObject[] _spawners;
    [SerializeField] private GameObject[] _prefabs;
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

        for (int i = 0; i < _maxEnemies;)
        {
            Instantiate(_prefabs[Random.Range(0, _prefabs.Count() - 1)], _spawners[i].transform.position, Quaternion.identity);
            i++;
            yield return timer;
        }
    }
}

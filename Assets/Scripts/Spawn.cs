using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    [SerializeField] GameObject _enemy;

    float _x, _y;

    private void Start()
    {
        InvokeRepeating("StartSpawn", 2, 2);
    }

    void StartSpawn()
    {

        _x = Random.Range(-5, 5);
        _y = Random.Range(-2, 2);

        Instantiate(_enemy, new Vector2(_x, _y), transform.rotation, transform);
    }

}

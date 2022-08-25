using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Bullet _bulletPrefab;

    private void Start()
    {
     
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_bulletPrefab, _shootPoint);
        }
    }

}

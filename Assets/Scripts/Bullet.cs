using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _deathRadius;
    private Rigidbody _rb;

    private void Start()
    {
       _rb =  GetComponent<Rigidbody>();

    }
    void Update()
    {
       // transform.Translate(Vector3.forward * _speed * Time.deltaTime);
          var _direction =   transform.TransformDirection(Vector3.forward);
        _rb.AddForce(_direction * _speed * Time.deltaTime, ForceMode.Impulse);
        BulletDestroyer();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Enemy enemy))
        {
            enemy.Die();
            Destroy(gameObject);
        }
    }

    private void BulletDestroyer()
    {
        if (transform.position.sqrMagnitude > _deathRadius * _deathRadius)
        {
            Destroy(gameObject);
        }
    }

  
}

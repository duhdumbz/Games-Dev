using System;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1;
    private Rigidbody2D _rb2d;
    private Transform _playerTransform;
    public bool Stopped = false;

    [SerializeField]
    private GameObject _crabDead;

    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        Player player = FindAnyObjectByType<Player>();
        if(player != null)
        {
            _playerTransform = player.transform;
        }
        else
        {
            Stopped = true;
        }

    }
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if(Stopped || _playerTransform == null)
        {
            _rb2d.linearVelocity = Vector3.zero;
            return;
        }
        Vector3 directionToPlayer = _playerTransform.position - transform.position;
        _rb2d.linearVelocity = directionToPlayer.normalized * _speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Weapon"))
        {
            Instantiate(_crabDead, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}   




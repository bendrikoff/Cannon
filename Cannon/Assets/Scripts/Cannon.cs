using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private GameObject _ball;
    [SerializeField] private Transform _ballSpawnPoint;
    

    [SerializeField] private float _fireSpeed;

    [SerializeField] private int _fireForce;

    private float _delay;
    
    private Queue<GameObject> _ballsPool;

    private void Start()
    {
        InitBalls();
    }

    private void Update()
    {
        _delay -= Time.deltaTime;
    }

    public void Fire()
    {
        if(_delay > 0) return;

        var ball = _ballsPool.Dequeue();
        ball.SetActive(true);
        var rbBall = ball.GetComponent<Rigidbody>();
        rbBall.AddForce(transform.right*_fireForce,ForceMode.Impulse);

        
        GameManager.Instance.Fire(_ballsPool.Count);
        
        _delay = 1f / _fireSpeed;

    }

    private void InitBalls()
    {
        _ballsPool = new Queue<GameObject>();
        
        int startBalls = GameManager.Instance.GetCountStartBalls;
        for (int i = 0; i < startBalls; i++)
        {
            var ball = Instantiate(_ball,_ballSpawnPoint.position,new Quaternion(),_ballSpawnPoint);
            ball.SetActive(false);
            _ballsPool.Enqueue(ball);
        }
    }
}

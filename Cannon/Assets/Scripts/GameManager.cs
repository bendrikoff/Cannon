using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static Level CurrentLevel;
    public int GetCountStartBalls => _startBalls;
    
    [SerializeField] public int _startBalls;
    
    public static GameManager Instance;
    
    private int _coins;

    private int _loseBalls;


    private void Awake()
    {
        Instance=this;
    }

    private void Start()
    {
        UIManager.Instance.ChangeLeftBallsCount(_startBalls);
    }

    public void AddOneScore()
    {
        _coins++;
        UIManager.Instance.ChangeCoinsCount(_coins);
    }

    public void Fire(int currentBalls)
    {
        if (currentBalls>0 )
        {
            UIManager.Instance.ChangeLeftBallsCount(currentBalls);
        }
        else if (_loseBalls == 0) 
        {
            Success();
        }
        else
        {
            Restart();
        }
    }

    public void AddOneLoseBall()
    {
        _loseBalls++;
    }

    private void Restart()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    private void Success()
    {
        SceneManager.LoadScene("Menu");
    }
    
}

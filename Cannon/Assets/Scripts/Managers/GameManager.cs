using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{

    public int GetCountStartBalls => _startBalls;
    public int GetBallsToWin => _ballsToWin;
    
    [SerializeField] private int _startBalls;

    [SerializeField] private int _ballsToWin;
    
   
    private int _coins;

    private int _loseBalls;


    private void Start()
    {
        UIManager.Instance.ChangeLeftBallsCount(_startBalls);
        
    }

    public void AddOneScore()
    {
        _coins++;
        UIManager.Instance.ChangeCoinsCount(_coins);
        if (_coins>=_ballsToWin)
        {
            Success();
        }
    }

    public void Fire(int currentBalls)
    {
        if (currentBalls>0)
        {
            UIManager.Instance.ChangeLeftBallsCount(currentBalls);
            SoundManager.Instance.PlayClickSound();
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
        UIManager.Instance.OpenWinPanel();
    }
    
}

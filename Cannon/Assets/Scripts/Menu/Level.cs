using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour,IClickable
{
    [SerializeField] private List<GameObject> _starsIcons;
    
    [SerializeField] private string _sceneName;
    public int GetLevelNumber => _levelNumber;
    
    [SerializeField] private int _levelNumber;

    [SerializeField] private int _stars;

    public void OnClick()
    {
        SceneManager.LoadScene(_sceneName);
    }

    public void SetStars(int count)
    {
        _stars = count;
    }
}

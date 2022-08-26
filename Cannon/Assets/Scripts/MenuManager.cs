using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _soundManager;
    
    void Awake()
    {
        if (SoundManager.Instance == null)
        {
            Instantiate(_soundManager);
        } 
    }


}

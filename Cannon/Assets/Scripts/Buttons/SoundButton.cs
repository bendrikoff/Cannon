using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour,IClickable
{ 
    [SerializeField] private Sprite _soundOnSprite;
    
    [SerializeField] private Sprite _soundOffSprite;
    
    private Image _soundImage;


    private bool _soundOn;

    private void Start()
    {
        _soundOn = true;
        _soundImage = GetComponent<Image>();
    }

    public void OnClick()
    {
        SwitchSound();
    }

    private void SwitchSound()
    {
        _soundOn = !_soundOn;
        
        _soundImage.sprite = _soundOn ? _soundOnSprite : _soundOffSprite;
    }
}

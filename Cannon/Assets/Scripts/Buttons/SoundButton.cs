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
    private bool _soundOn => SoundManager.Instance.SoundIsOn;

    private void Start()
    {
        _soundImage = GetComponent<Image>();
        _soundImage.sprite = _soundOn ? _soundOnSprite : _soundOffSprite;

    }

    public void OnClick()
    {
        SwitchSound();
    }

    private void SwitchSound()
    {
        SoundManager.Instance.SwitchSound();
        _soundImage.sprite = _soundOn ? _soundOnSprite : _soundOffSprite;
    }
}

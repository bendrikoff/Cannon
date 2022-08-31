using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
   [SerializeField] private AudioSource _clickAudio;
   [SerializeField] private AudioSource _backgroundAudio;
   public bool SoundIsOn => _soundOn;

   private bool _soundOn;

   protected override void Awake()
   {
      if (Instance != null) return;
      base.Awake();
      Init();
   }

   public void PlayClickSound()
   {
      _clickAudio.Play();
   }

   public void SwitchSound()
   {
      _soundOn = !_soundOn;
      
      if (_soundOn)
      {
         _clickAudio.volume = 1;
         _backgroundAudio.volume = 1;
      }
      else
      {
         _clickAudio.volume = 0;
         _backgroundAudio.volume = 0;
      }
   }

   private void Init()
   {
      _soundOn = true;
      
      DontDestroyOnLoad(this);
   }
}

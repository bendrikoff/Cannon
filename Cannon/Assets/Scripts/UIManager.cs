using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
   [SerializeField] private GameObject _winPanel;
   
   [SerializeField] private TextMeshProUGUI _leftBallsCountText;
   
   [SerializeField] private TextMeshProUGUI _coinsBallsCountText;
   
   public static UIManager Instance;

   private void Start()
   {
      Instance = this;
      ChangeCoinsCount(0);
   }

   public void ChangeLeftBallsCount(int count)
   {
      _leftBallsCountText.text = count.ToString();
   }

   public void ChangeCoinsCount(int count)
   {
     _coinsBallsCountText.text = count+"/"+GameManager.Instance.GetBallsToWin;
   }

   public void OpenWinPanel()
   {
      _winPanel.SetActive(true);
   }
}

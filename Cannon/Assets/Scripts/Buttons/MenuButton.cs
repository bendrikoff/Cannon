using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour,IClickable
{
    public void OnClick()
    {
        SceneManager.LoadScene("Menu");
    }
}

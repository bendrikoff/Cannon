using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEditor.SearchService.Scene;

namespace Buttons
{
    public class RestartButton : MonoBehaviour,IClickable
    {
        public void OnClick()
        {
            var scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
            Debug.Log("Нажал Restart");

        }
    }
}

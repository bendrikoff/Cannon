using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Ball ball))
        {
            other.gameObject.SetActive(false);
            GameManager.Instance.AddOneLoseBall();
            Debug.Log("Border");
        }
    }
}

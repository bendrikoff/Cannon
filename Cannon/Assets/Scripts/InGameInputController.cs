using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameInputController : MonoBehaviour
{
    [SerializeField] private Cannon _cannon;

    private Camera _camera;
    private bool _isCannonNotNull;

    private void Start()
    {
        _camera=Camera.main;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit2D aHit = new RaycastHit2D();
            aHit = Physics2D.Raycast(_camera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            
            if (aHit.collider != null&&
                aHit.collider.gameObject.TryGetComponent(out IClickable clickable))
            {
                clickable.OnClick();
            }
            else 
            {
                _cannon.Fire();
            }
        }
    }
}

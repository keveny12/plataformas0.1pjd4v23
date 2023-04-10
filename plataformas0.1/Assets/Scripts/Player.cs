using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;

    private GameControls _controls;
    private Vector2 _moveInput;
    private bool _isatirando;

    private void OnEnable()
    {
        _playerInput.onActionTriggered += OnAction;
    }

    private void OnDisable()
    {
        _playerInput.onActionTriggered -= OnAction;
    }

    // Start is called before the first frame update
    void Awake()
    {
       
        _controls = new GameControls();
    }

    private void OnAction(InputAction.CallbackContext playerAct)
    {
        if (playerAct.action.name == _controls.Gameplay.Tiro.name)
        {
            //fazer o jogador atirar
            //Input System
            //playerAct.stared
            //playerAct.performed
            //playerAct.canceled
            if (playerAct.started)
                _isatirando = true;
            else if (playerAct.canceled)
                _isatirando = false;
        }

        if (playerAct.action.name == _controls.Gameplay.Movimento.name)
        {
            _moveInput = playerAct.ReadValue<Vector2>();
        }
    }
    
}

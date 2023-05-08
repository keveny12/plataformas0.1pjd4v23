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

    private int _points;
    private int _currentEnergy;
    [SerializeField] private int maxEnergy;

    public Rigidbody2D oRigidbody2D;
    //para mover o rigidbody

    public GameObject tiroNormal;
    
    public Transform localDoTiroNormal;
    
    
    public float velocidadeDoJogador;

    public bool temTiroDuplo;

    private Vector2 teclasApertadas;
   //move os dois eixos
   
   
   

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

    private void Addpoints(int amount)
    {
       


    }

    void Update()
    {
        MovimentoJogador();
    }

    private void MovimentoJogador()
    {
        teclasApertadas = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        oRigidbody2D.velocity = teclasApertadas.normalized * velocidadeDoJogador;
    }

    private void DispararTiro()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (temTiroDuplo == false)
            {
                
            }
        }
        
    }
}

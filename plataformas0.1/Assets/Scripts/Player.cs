using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public int Vida = 5;
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

    public KeyCode botãoTiro = KeyCode.Space;//chama o botao para atirar segurando o botao
    public float tempoDoTiro = 0.5f;
    private float ProximoTiro = 0.0f;
    
    public Transform localDoTiroNormal;//aonde o tiro sai
    
    
    public float velocidadeDoJogador;

    public bool temTiroDuplo;

    private Vector2 teclasApertadas;//move os dois eixos
    public GameObject[] tiros;//array dos tiros
    private int listaDeTirosAtual = 0;//lista de tiro atual


   private void Start()
   {
       temTiroDuplo = false;
       GameController.instance.UpdateVidas(Vida);
   }

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
        DispararTiro();

        if (Input.GetKeyDown(KeyCode.Z))//troca o tiro quando apertar o z
        {
            
            listaDeTirosAtual++;//altera na lista para alterar para o proximo tiro

            if (listaDeTirosAtual >= tiros.Length)//quando acabar o array volta para o primeiro tiro
            {
                listaDeTirosAtual = 0;
            }
            


        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DispararTiro();
        }
        
    }

    private void MovimentoJogador()
    {
        teclasApertadas = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        oRigidbody2D.velocity = teclasApertadas.normalized * velocidadeDoJogador;
    }

    private void DispararTiro()
    {
        if (Input.GetKey(botãoTiro) && Time.time > ProximoTiro)
        {
            ProximoTiro = Time.time + tempoDoTiro;
            if (temTiroDuplo == false)
            {
                if(tiroNormal != null)//verificar
                    Instantiate(tiros[listaDeTirosAtual], localDoTiroNormal.position, localDoTiroNormal.rotation);
            }
        }
        
    }

    public void Damage(int dmg)
    {
        Vida -= dmg;

        if (Vida <= 0)
        {
           // chama o game over
        }
    }
}

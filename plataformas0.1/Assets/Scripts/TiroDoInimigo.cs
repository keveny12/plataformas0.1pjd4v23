using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TiroDoInimigo : MonoBehaviour
{
    public float VelocidadeDoTiro;
    public int danoParaDar;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentoTiro();
    }

    private void MovimentoTiro()
    {
        transform.Translate(Vector3.up * VelocidadeDoTiro * Time.deltaTime);//tranlate realiza um movimento no gameobject
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<VidaDoJogador>().DanoJogador(danoParaDar);
            
            
        } 
    }

    void OnTriggerEnter2D(Collider2D other)//diz qual objeto colidiu com o jogador
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<VidaDoJogador>().DanoJogador(danoParaDar);
            Destroy(this.gameObject);
        }
    }
}

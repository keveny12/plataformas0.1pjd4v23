using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDoJogador : MonoBehaviour
{
    public int vidaMaximaDoJogador;

    public int vidaAtualDoJogador;

    public bool temEscudo;
    // Start is called before the first frame update
    void Start()
    {
        vidaAtualDoJogador = vidaMaximaDoJogador;//sempre que o jogo iniciar a vida atual sera igual a vida maxima
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DanoJogador(int danoParaReceber)
    {
        if (temEscudo == false)
        {
            vidaAtualDoJogador -= danoParaReceber;

            if (vidaAtualDoJogador <= 0)//sempre que o jogador morrer vai rodar esse codigo
            {
                Debug.Log("Game Over");
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//diz para unity que estamos a ultilizar comando de interface do usuario

public class VidaDoJogador : MonoBehaviour
{
    public Slider barraDeVidaDoJogador;//variavel para asessar barra de vida pelo slider
    
    public int vidaMaximaDoJogador;

    public static int vidaAtualDoJogador = 20;

    public bool temEscudo;
    // Start is called before the first frame update
    void Start()
    {
        vidaAtualDoJogador = vidaMaximaDoJogador;//sempre que o jogo iniciar a vida atual sera igual a vida maxima
        barraDeVidaDoJogador.maxValue = vidaMaximaDoJogador;// quando o jogo inicia o valor maximo da barra vai ser igual ao valor maximo da vida do jogador
        barraDeVidaDoJogador.value = vidaAtualDoJogador;//sempre que levar dano atualisa a barra com a vida atual do jogador
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
            barraDeVidaDoJogador.value = vidaAtualDoJogador;

            if (vidaAtualDoJogador <= 0)//sempre que o jogador morrer vai rodar esse codigo
            {
                Debug.Log("perdeu hp");
                vidaAtualDoJogador = vidaMaximaDoJogador;
                barraDeVidaDoJogador.value = vidaAtualDoJogador;
                GameController.instance.TirarVida();
            }
           
        }
    }
}

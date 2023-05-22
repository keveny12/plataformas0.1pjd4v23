using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//diz para unity que estamos a ultilizar comando de interface do usuario

public class VidaDoJogador : MonoBehaviour
{
    public Slider barraDeVidaDoJogador;//variavel para asessar barra de vida pelo slider
    
    public int vidaMaximaDoJogador;

    public static int vidaAtualDoJogador = 20;

    public int vidaMaximaDoEscudo;
    public int vidaAtualDoEscudo;

    public bool temEscudo;
    public GameObject escudoDoJogador;    // Start is called before the first frame update
    void Start()
    {
        vidaAtualDoJogador = vidaMaximaDoJogador;//sempre que o jogo iniciar a vida atual sera igual a vida maxima
        barraDeVidaDoJogador.maxValue = vidaMaximaDoJogador;// quando o jogo inicia o valor maximo da barra vai ser igual ao valor maximo da vida do jogador
        barraDeVidaDoJogador.value = vidaAtualDoJogador;//sempre que levar dano atualisa a barra com a vida atual do jogador
        
        escudoDoJogador.SetActive(false);//sempre que começa o jogo o escudo vai ta desativado, pois é um power up
        temEscudo = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AtivarEscudo() //vai ativar o escudo quando a caixinha estiver marcada
    {
        vidaAtualDoEscudo = vidaMaximaDoEscudo;
        
        escudoDoJogador.SetActive(true);//pede para unity ativar o objeto
        temEscudo = true;
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
        else
        {
            vidaAtualDoEscudo -= danoParaReceber;
            if (vidaAtualDoEscudo <= 0)
            {
                escudoDoJogador.SetActive(false);//desativa o escudo
                temEscudo = false;
            }
        }
    }
}

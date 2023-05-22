using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigos : MonoBehaviour
{
    public GameObject tiroDoInimigo;

    public Transform localDoTiro;
    
    public float VelocidadeDoInimigo;
    public int vidaMaximaDoInimigo;
    public int vidaAtualDoInimigo;
    public int darPontos;

    public float tenpoMaximoEntreOsTiros;
    public float tempoAtualDosTiros;

    public bool inimigoAtirador;
    public bool atirarTiros1;
    public bool atirarTiros2;
    public bool atirarTiros3;
    public bool temEscudo;
    public GameObject escudoDoInimigo;//servira de referencia ao game object do escudo
    public int vidaMaximaDoEscudo;
    public int vidaAtualDoEscudo;

    
    

    // Start is called before the first frame update
    void Start()
    {
        vidaAtualDoInimigo = vidaMaximaDoInimigo;
        escudoDoInimigo.SetActive(true);
        temEscudo = true;
    }

    // Update is called once per frame
    void Update()
    {
        MovimentoInimigo();

        if (atirarTiros1)
        {
            AtirarTiros1();
        }

        if (atirarTiros2)
        {
            AtirarTiros2();
        }
        
        if (atirarTiros3)
        {
            AtirarTiros3();
        }

        if (inimigoAtirador == true)//se for atirador vai atirar
        {
            
        }
    }
    public void AtivarEscudo() //vai ativar o escudo quando a caixinha estiver marcada
    {
        vidaAtualDoEscudo = vidaMaximaDoEscudo;
        
        escudoDoInimigo.SetActive(true);//pede para unity ativar o objeto
        temEscudo = true;
    }

    private void MovimentoInimigo()
    {
        transform.Translate(Vector3.up * VelocidadeDoInimigo * Time.deltaTime);
    }

    private void AtirarTiros1()
    {
        tempoAtualDosTiros -= Time.deltaTime;

        if (tempoAtualDosTiros <= 0)//cronometro sempre que chegar a 0 a nave atira
        {
            float angulo = Random.Range(-30f, 30f);
            Instantiate(tiroDoInimigo, localDoTiro.position, Quaternion.Euler(0f, 0f, angulo + 90));//instancia um tiro nessa posição
            tempoAtualDosTiros = tenpoMaximoEntreOsTiros;//reserta o cronometro
        }
    }
    private void AtirarTiros2()
    {
        tempoAtualDosTiros -= Time.deltaTime;

        if (tempoAtualDosTiros <= 0)//cronometro sempre que chegar a 0 a nave atira
        {
            float angulo = Random.Range(-60f, 60f);
            Instantiate(tiroDoInimigo, localDoTiro.position, Quaternion.Euler(0f, 0f, angulo + 90));//instancia um tiro nessa posição
            tempoAtualDosTiros = tenpoMaximoEntreOsTiros;//reserta o cronometro
        }
    }
    private void AtirarTiros3()
    {
        tempoAtualDosTiros -= Time.deltaTime;

        if (tempoAtualDosTiros <= 0)//cronometro sempre que chegar a 0 a nave atira
        {
            float angulo = Random.Range(-90f, 90f);
            Instantiate(tiroDoInimigo, localDoTiro.position, Quaternion.Euler(0f, 0f, angulo + 90));//instancia um tiro nessa posição
            tempoAtualDosTiros = tenpoMaximoEntreOsTiros;//reserta o cronometro
        }
    }

    public void DanoInimigo(int danoParaReceber)
    {
        if (temEscudo == false)
        {
            vidaAtualDoInimigo -= danoParaReceber;

            if (vidaAtualDoInimigo <= 0)
            {
                GameManager.Instance.AumentoPontos(darPontos);
                Destroy(this.gameObject);
            }
        }
        else
        {
            vidaAtualDoEscudo -= danoParaReceber;
            if (vidaAtualDoEscudo <= 0)
            {
                escudoDoInimigo.SetActive(false);//desativa o escudo
                temEscudo = false;
            }
        }
    }
    
}

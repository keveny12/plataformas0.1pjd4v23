using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigos : MonoBehaviour
{
    public GameObject tiroDoInimigo;

    public Transform localDoTiro;
    
    public float VelocidadeDoInimigo;

    public float tenpoMaximoEntreOsTiros;
    public float tempoAtualDosTiros;

    public bool inimigoAtirador;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentoInimigo();

        if (inimigoAtirador == true)//se for atirador vai atirar
        {
            AtirarTiros();
        }
    }

    private void MovimentoInimigo()
    {
        transform.Translate(Vector3.up * VelocidadeDoInimigo * Time.deltaTime);
    }

    private void AtirarTiros()
    {
        tempoAtualDosTiros -= Time.deltaTime;

        if (tempoAtualDosTiros <= 0)//cronometro sempre que chegar a 0 a nave atira
        {
            Instantiate(tiroDoInimigo, localDoTiro.position, Quaternion.Euler(0f, 0f, 90f));//instancia um tiro nessa posição
            tempoAtualDosTiros = tenpoMaximoEntreOsTiros;//reserta o cronometro
        }
    }
    
}
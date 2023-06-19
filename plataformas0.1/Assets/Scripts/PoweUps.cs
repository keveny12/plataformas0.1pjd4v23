using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweUps : MonoBehaviour
{
    //variaves de verificacao
    public bool PowerUpDeEscudo;//diz se o item e de escudo
    public bool PowerUpMunicao;
    public bool PowerUpSuperTiro;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))//mostrar quem colidiu com o powerup
        {
            if (PowerUpDeEscudo == true)
            {
                other.gameObject.GetComponent<VidaDoJogador>().AtivarEscudo();
            }

            if (PowerUpMunicao == true)
            {
               // other.gameObject.GetComponent<>() = false; //toda vez que pegar municao nova vai acabar a antiga antes de enche novamente
                
            }

            if (PowerUpSuperTiro == true)
            {
                
            }
            
            Destroy(this.gameObject);
        }
    }
}

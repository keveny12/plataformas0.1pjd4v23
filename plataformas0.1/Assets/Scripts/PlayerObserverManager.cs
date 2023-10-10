using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;

public static class PlayerObserverManager
{
    public static Action<float> OnBarraDeVidaPlayer;

    public static void BarraChanged(float Barra)
    {
        OnBarraDeVidaPlayer?.Invoke(Barra);
    }
    public static Action<int> OnPontuacaoAtual;

    public static void PontosChanged(int Pontos)
    {
        OnPontuacaoAtual?.Invoke(Pontos);
    }
    
    public static Action<int> OnVida;

    public static void VidaChanged(int Vida)
    {
       OnVida?.Invoke(Vida);
    }
    
   // public static Action<int> OnBarraDeVidaBoss;

    //public static void BarrabossChanged(int Barraboss)
   // {
   //     OnBarraDeVidaBoss?.Invoke(Barraboss);
   // }

}

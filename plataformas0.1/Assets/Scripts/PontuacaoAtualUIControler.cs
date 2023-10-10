using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontuacaoAtualUIControler : MonoBehaviour
{
  private Text pontosText;
  private void OnEnable()
  {
    PlayerObserverManager.OnPontuacaoAtual += UpdatePontos;
  }
  private void OnDisable()
  {
    PlayerObserverManager.OnPontuacaoAtual -= UpdatePontos;
  }

  private void Awake()
  {
    pontosText = GetComponent<Text>();
    
  }

  private void UpdatePontos(int value)
  {
    pontosText.text = value.ToString();
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaUIController : MonoBehaviour
{
    private Text vidaText;
    private void OnEnable()
    {
        PlayerObserverManager.OnVida += UpdateVidas;
    }
    private void OnDisable()
    {
        PlayerObserverManager.OnVida -= UpdateVidas;
    }

    private void Awake()
    {
        vidaText = GetComponent<Text>();
    
    }

    private void UpdateVidas(int value)
    {
        vidaText.text = value.ToString();
    }
}

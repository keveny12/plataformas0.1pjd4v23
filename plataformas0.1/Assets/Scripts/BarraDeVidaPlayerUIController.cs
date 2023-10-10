using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVidaPlayerUIController : MonoBehaviour
{
    private Slider barraSlider;
    private void OnEnable()
    {
        PlayerObserverManager.OnBarraDeVidaPlayer += UpdateBarra;
    }
    private void OnDisable()
    {
        PlayerObserverManager.OnBarraDeVidaPlayer -= UpdateBarra;
    }

    private void Awake()
    {
        barraSlider = GetComponent<Slider>();
    
    }

    private void UpdateBarra(float value)
    {
        barraSlider.value = value;
    }
}

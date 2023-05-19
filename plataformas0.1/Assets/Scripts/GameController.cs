using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int vidaMaxima = 5;
    private int vidaDurante;
    public Text vidaText;

    public static GameController instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        vidaDurante = vidaMaxima;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateVidas(int value)
    {
        vidaText.text = "X " + value.ToString();
    }
}

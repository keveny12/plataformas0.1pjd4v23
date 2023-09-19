using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        UpdateVidas(vidaDurante);
    }

    // Update is called once per frame
    void Update()
    {
        vidaText.text = "x " + vidaDurante.ToString();
    }

    public void UpdateVidas(int value)
    {
        vidaText.text = "X " + value.ToString();
        
    }

    public void TirarVida()
    {
        vidaDurante--; // tira uma vida do jogador

        if (vidaDurante <= 0)
        {
            Morrer();
        }
        
        UpdateVidas(vidaDurante);
    }

    public void AumentarVida()
    {
        if (vidaDurante < vidaMaxima)
        {
            vidaDurante++;
            UpdateVidas(5);
        }
    }

    public void Morrer()
    {
        Debug.Log("Game Over");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
}

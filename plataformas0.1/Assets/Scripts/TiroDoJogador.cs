using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroDoJogador : MonoBehaviour
{
    public float velocidadeDoTiro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentoTiro();
    }

    private void MovimentoTiro()
    {
        transform.Translate(Vector3.up * velocidadeDoTiro * Time.deltaTime);
    }
}

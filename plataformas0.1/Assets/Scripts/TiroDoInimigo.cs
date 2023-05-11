using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroDoInimigo : MonoBehaviour
{
    public float VelocidadeDoTiro;
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
        transform.Translate(Vector3.up * VelocidadeDoTiro * Time.deltaTime);//tranlate realiza um movimento no gameobject
    }
}

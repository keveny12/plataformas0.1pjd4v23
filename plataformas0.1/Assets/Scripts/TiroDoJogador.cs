using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroDoJogador : MonoBehaviour
{
    public float velocidadeDoTiro;
    public int danoParaDar;
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
    
    void OnTriggerEnter2D(Collider2D other)//diz qual objeto colidiu com o jogador
    {
        if (other.gameObject.CompareTag("Inimigo"))
        {
            other.gameObject.GetComponent<Inimigos>().DanoInimigo(danoParaDar);
            Destroy(this.gameObject);
        }
    }
}

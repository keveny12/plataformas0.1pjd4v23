using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisorDeMunição : MonoBehaviour
{
    public int munição;
    public Text visorDeMunição;

    public bool estaAtirando;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        visorDeMunição.text = munição.ToString();
        if (Input.GetMouseButtonDown(0) && !estaAtirando && munição > 0)
        {
            estaAtirando = true;
            munição--;
            estaAtirando = false;
        }
    }
}

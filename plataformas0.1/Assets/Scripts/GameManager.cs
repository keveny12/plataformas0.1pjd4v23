using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int pontuacaoRecebida;
    public Text textoDaPontuaçaoRecebida;
    public static GameManager Instance;

    [SerializeField] private GameObject enemyControllerPrefab;

    [SerializeField] private List<EnemySO> enemyTypes;
    
    private void Awake()
    {
        Instance = this;
        // if (Instance == null)
        //{
        //   Instance = this;
        //   DontDestroyOnLoad(transform);
        // }
        // else
        //    Destroy(gameObject);
    }

    private void Start()
    {
        pontuacaoRecebida = 0;
        textoDaPontuaçaoRecebida.text = "PONTUAÇÃO: " + pontuacaoRecebida;
        //LoadScene("MainMenu");
    }
        
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    private void Update()
    {
    //    if (Keyboard.current.digit1Key.wasPressedThisFrame)
     //   {
     //       SpawnEnemy(0);
     //   }
     //   if (Keyboard.current.digit2Key.wasPressedThisFrame)
      //  {
      //      SpawnEnemy(1);
      //  }
     //   if (Keyboard.current.digit3Key.wasPressedThisFrame)
     //   {
     //       SpawnEnemy(2);
     //   }
      //  if (Keyboard.current.digit4Key.wasPressedThisFrame)
      //  {
      //      SpawnEnemy(3);
      //  }
    }

    public void SpawnEnemy(int enemyType)
    {
        GameObject enemy = Instantiate(enemyControllerPrefab);
        
        int hp = enemyTypes[enemyType].hp;
        Sprite sprite = enemyTypes[enemyType].sprite;
        
        enemy.GetComponent<EnemyController>().initialize(hp, sprite);
    }

    public void AumentoPontos(int ganharPontos)
    {
        pontuacaoRecebida += ganharPontos;
        textoDaPontuaçaoRecebida.text = "PONTUAÇÃO: " + pontuacaoRecebida;
    }

   
}

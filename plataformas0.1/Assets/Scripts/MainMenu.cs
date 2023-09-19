using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    //public string SceneName;
    public void LoadGame()
    {
        
        GameManager.Instance.LoadLevel();
    }
}

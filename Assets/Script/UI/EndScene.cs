using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void ToStart()
    {
        SceneManager.LoadScene("Start");
    }
    
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}

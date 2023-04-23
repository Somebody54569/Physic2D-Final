using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static Pause instance;
    private void Start()
    {
        instance = this;
        EventSystem[] eventSystems = FindObjectsOfType<EventSystem>();
        if (eventSystems.Length > 1)
        {
            Destroy(eventSystems[1].gameObject);
        }
        
    }

    public void Resume()
    {
        Time.timeScale = 1;
        Launcher.instance.isPaused = false;
        SceneManager.UnloadSceneAsync("Pause");
    }

    public void LoadMenu()
    {
        Time.timeScale = 1;
        LevelManager.instance.ResetPlayThroughStars();
        SceneManager.LoadScene("Menu");
    }
    
    public void LoadLevel()
    {
        Time.timeScale = 1;
        LevelManager.instance.ResetPlayThroughStars();
        SceneManager.LoadScene("Level Select");
    }
    public void Quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

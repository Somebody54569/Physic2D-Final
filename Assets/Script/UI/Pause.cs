using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    private void Start()
    {
        EventSystem[] eventSystems = FindObjectsOfType<EventSystem>();
        if (eventSystems.Length > 1)
        {
            Destroy(eventSystems[1].gameObject);
        }
        
    }

    public void Resume()
    {
        Time.timeScale = 1;
        SceneManager.UnloadSceneAsync("Pause");
    }

    public void LoadMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start");
    }
    
    public void LoadLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level Select");
    }
    public void Quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}

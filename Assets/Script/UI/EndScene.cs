using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScene : MonoBehaviour
{
    [SerializeField] private Text totalStar;
    [SerializeField] private Text highestStar;
    private void Start()
    {
        // Show the total number of stars obtained on play through
        int totalStars = LevelManager.instance.playThroughStars[0] + LevelManager.instance.playThroughStars[1] + LevelManager.instance.playThroughStars[2];
        totalStar.text = $"{totalStars}/9";
        // Show best Score
        int highestStars = LevelManager.instance.highestStars[0] + LevelManager.instance.highestStars[1] + LevelManager.instance.highestStars[2];
        
        PlayerPrefs.SetInt("HighestStars", highestStars);
        highestStar.text = $"Best Score : {PlayerPrefs.GetInt("HighestStars")}/9";
    }

    public void RestartGame()
    {
        LevelManager.instance.ResetPlayThroughStars();
        SceneManager.LoadScene("Level 1");
    }

    public void ToStart()
    {
        LevelManager.instance.ResetPlayThroughStars();
        SceneManager.LoadScene("Menu");
    }
    
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    public void LevelSelect()
    {
        LevelManager.instance.ResetPlayThroughStars();
        SceneManager.LoadScene("Level Select");
    }
}

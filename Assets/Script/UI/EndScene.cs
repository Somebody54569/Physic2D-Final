using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    [SerializeField] private TMP_Text totalStar;
    [SerializeField] private TMP_Text highestStar;
    private void Start()
    {
        // Show the total number of stars obtained
        int totalStars = LevelManager.instance.highestStars[0] + LevelManager.instance.highestStars[1] + LevelManager.instance.highestStars[2];
        totalStar.text = $"You Got {totalStars}/9 Star!!!" ;

        // Show the highest number of stars obtained in each level
        highestStar.text = "Highest Stars\n" +
                           "Level 1: " + LevelManager.instance.highestStars[0].ToString() + "\n" +
                           "Level 2: " + LevelManager.instance.highestStars[1].ToString() + "\n" +
                           "Level 3: " + LevelManager.instance.highestStars[2].ToString();
    }

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

    public void LevelSelect()
    {
        SceneManager.LoadScene("Level Select");
    }
}

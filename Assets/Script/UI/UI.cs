using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public static UI instance;
    
    public TMP_Text ballText;
    public TMP_Text starText;

    public GameObject youWin;
    public Image star1;
    public Image star2;
    public Image star3;
    
    public GameObject youLose;

    private void Start()
    {
        instance = this;
    }

    public void UpdateText()
    {
        ballText.text = $"Ball Remaining : {Launcher.instance.remainingBall}";
        starText.text = $"Star Get : {Launcher.instance.starGet}";
    }

    public void Win()
    {
        youWin.SetActive(true);
        switch (Launcher.instance.starGet)
        {
            case 1:
                star1.color = Color.yellow;
                break;
            case 2:
                star1.color = Color.yellow;
                star2.color = Color.yellow;
                break;
            case 3:
                star1.color = Color.yellow;
                star2.color = Color.yellow;
                star3.color = Color.yellow;
                break;
        }
        
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ToStart()
    {
        SceneManager.LoadScene("Start");
    }

    public void ToResult()
    {
        SceneManager.LoadScene("End");
    }
}

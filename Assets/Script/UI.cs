using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public static UI instance;
    
    public TMP_Text ballText;
    public TMP_Text starText;

    public GameObject youWin;
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
}

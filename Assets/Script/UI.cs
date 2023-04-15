using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TMP_Text ballText;
    public static UI instance;

    public GameObject youWin;
    public GameObject youLose;

    private void Start()
    {
        instance = this;
    }

    public void updateText()
    {
        ballText.text = $"Ball Remaining : {Launcher.instance.remainingBall}";
    }
}

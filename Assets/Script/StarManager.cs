using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarManager : MonoBehaviour
{
    public static int totalStar;

    private void Start()
    {
        totalStar = 0;
    }

    
    
    public static void AddStar(int star)
    {
        totalStar += star;
    }
    
    
}

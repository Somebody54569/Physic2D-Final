using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Singleton pattern to ensure only one instance of LevelManager throughout the game
    public static LevelManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Array to store the highest number of stars obtained in each level
    public int[] highestStars = new int[3];

    // Function to get the highest number of stars obtained for a given level
    public int GetHighestStarsForLevel(int levelIndex)
    {
        return highestStars[levelIndex - 1];
    }

    // Function to update the highest number of stars obtained for a given level
    public void UpdateHighestStarsForLevel(int levelIndex, int stars)
    {
        if (stars > highestStars[levelIndex - 1])
        {
            highestStars[levelIndex - 1] = stars;
        }
    }

    // Function to reset the highest number of stars obtained for all levels
    public void ResetHighestStars()
    {
        highestStars = new int[3];
    }
}

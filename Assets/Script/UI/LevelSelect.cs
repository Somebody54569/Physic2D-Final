using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public Sprite star1, star2, star3;

    public Image level1, level2, level3;
    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        switch (LevelManager.instance.highestStars[0])
        {
            case 1:
                level1.sprite = star1;
                break;
            case 2:
                level1.sprite = star2;
                break;
            case 3:
                level1.sprite = star3;
                break;
        }
        
        switch (LevelManager.instance.highestStars[1])
        {
            case 1:
                level2.sprite = star1;
                break;
            case 2:
                level2.sprite = star2;
                break;
            case 3:
                level2.sprite = star3;
                break;
        }
        switch (LevelManager.instance.highestStars[2])
        {
            case 1:
                level3.sprite = star1;
                break;
            case 2:
                level3.sprite = star2;
                break;
            case 3:
                level3.sprite = star3;
                break;
        }
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }
    
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }
    
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }
}

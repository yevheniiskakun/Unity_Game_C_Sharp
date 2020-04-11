using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class HUDmanager : MonoBehaviour
{   
    public Text ScoreText;
    int[] highestscore;
    
    // Start is called before the first frame update
    void Start()
    {   
        ScoreText.text = "Score: 5";
        Player.score = 5;
    }

    // Update is called once per frame
    void Update()
    {   
        highestscore = Player.maxScore.ToArray();
        Array.Sort(highestscore);
        string scoreString = Player.score.ToString();
        string maxscoreString = highestscore[highestscore.Length - 1].ToString();
        ScoreText.text = "Score: " + scoreString + " Max score: " + maxscoreString;
        Debug.Log(" Max score: " + maxscoreString);
    }
}

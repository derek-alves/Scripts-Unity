using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
   
   public Text scoreText;
   public int totalScore; // Start is called before the first 
   public static GameController instance;
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText(){
        scoreText.text = totalScore.ToString();
    }

}

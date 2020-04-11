using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Threading;
using System.Collections.Generic;
using UnityEngine.Advertisements;

public class Player : MonoBehaviour
{   
   public GameObject restart;  
   public static bool lose = false;

   public static int score = 5;
   public static List<int> maxScore = new List<int>();
    /*
    string gameId = "3547394";
    string myPlacementId = "restarting";
    bool testMode = true;
    */
   void Awake(){
       lose = false;
   }
  /* void Start(){
       Advertisement.AddListener (this);
       Advertisement.Initialize (gameId, testMode);
   }*/
   void OnTriggerEnter2D(Collider2D other){
       if(other.gameObject.tag == "Bug"){
          score-=10;
       }
       if(other.gameObject.tag == "Dollar"){
           score+=5;
           maxScore.Add(score);
          // DollarFallDown.Update.Destroy(gameObject);
       }
       if(score <= 0){
           lose = true;
           restart.SetActive(true);
          // Advertisement.Show (myPlacementId);
       }
   }
}

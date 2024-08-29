using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
   
//    public Transform Player;
//    public Text scoreText;

   public float x = -9.940001f;


//     // Update is called once per frame
//     void Update()
//     {
//       //  Debug.Log(Player.position.z);
//       scoreText.text = (Player.position.z+x).ToString("0");

//     }

public GameObject startPos;
public Text scoreText;
public GameObject scoreTextObj;

//Final AND High score
// public TMP_Text finalScoreText;
// public TMP_Text highScoreText;

private float distance;

void Start()
{
    //Updating Score Text On Screen 
    scoreText = scoreTextObj.GetComponent<Text>();
}

void Update()
{
    //Distance Is Score
    distance = (startPos.transform.position.z+x + this.transform.position.z+ x);
    scoreText.text = distance.ToString("0") + "M";
}

// public void HighScoreUpdate()
// {
//     //Is there already a high score
//     if (PlayerPrefs.HasKey("SavedHighScore"))
//     {
//         //is the new score Higer than the saved score
//         if(distance > PlayerPrefs.GetFloat("SavedHighScore") )
//         {
//             //Set New High score
//             PlayerPrefs.SetFloat("SavedHighScore", distance);
//         }
//     }
//     else
//     {
//         //If no Hige Score Set it
//         PlayerPrefs.SetFloat("SavedHighScore", distance);
//     }

//     //Updating TMP
//     finalScoreText.text = distance.ToString();
//     highScoreText.text = PlayerPrefs.GetFloat("SavedHighScore").ToString();
// }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HearthSystem : MonoBehaviour
{
    public int playerHealth;

    [SerializeField] private Image[] hearts;

   // public Score scoreManager;


    public void Start()
    {
        UpdateHealth();
       
    }

    // Update is called once per frame
   public void UpdateHealth()
    {
        //Check game Over If player Healt Null
        if (playerHealth <= 0)
        {
            //Game over
            
            SceneController.LoadScene(2);

            //calll high Score
           // scoreManager.HighScoreUpdate();
        }

        for(int i = 0; i < hearts.Length; i++)
        {
            if(i < playerHealth)
            {
                hearts[i].color = Color.red;
            }
            else 
            {
                hearts[i].color = Color.black;
            }
        }
    }

  
    
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
   public bool gameOver = false;

   public void Play()
   {
      
        SceneController.LoadScene(1);
   }

   public void GameOver()
   {
      SceneController.LoadScene(2);
   }

   public void Restart()
   {
     SceneController.Restart();
     SceneController.LoadScene(0);
     gameOver = true;
   }

   public void NextLevel()
   {
        SceneController.LoadScene(3);
   }

   public void SceneLoad(int sceneIndex)
   {
         SceneController.LoadScene(sceneIndex);
   }
   public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
          // Deactivate the GUI panel after quitting the game
          // guiPanel.SetActive(false);
        #endif
    }
}

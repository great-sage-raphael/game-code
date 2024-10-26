using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicmanager : MonoBehaviour
{
   public int points;
   public Text score;
   public GameObject gameoverscreen;
   
   [ContextMenu("increment score")]
   public  void addpoints(int points1)
   {
        points +=points1;
        score.text=points.ToString();
   }
   public void restartgame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
   public void gameover()
   {
      gameoverscreen.SetActive(true);
   }

}

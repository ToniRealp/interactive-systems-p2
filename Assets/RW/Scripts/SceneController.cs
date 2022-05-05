using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
   public void LoadMainScene()
   {
      SceneManager.LoadScene("Game");
   }

   private void OnEnable()
   {
      EventManager.OnGameOver.AddListener(() =>
      {
         SceneManager.LoadScene("Title");
      });
   }
   
   private void OnDisable()
   {
      EventManager.OnGameOver.RemoveListener(() =>
      {
         SceneManager.LoadScene("Title");
      });
   }
}

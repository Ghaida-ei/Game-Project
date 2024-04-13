using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Levels : MonoBehaviour
{
    public void GoToLevel1()
    {
        StartCoroutine(LoadSceneWithDelay(2));
    }
   
    public void GoToLevel2()
    {
        StartCoroutine(LoadSceneWithDelay(3));
    }

    public void GoToLevel3()
    {
       StartCoroutine(LoadSceneWithDelay(4)); 
    }

    public void GoToGameOver()
    {
        StartCoroutine(LoadSceneWithDelay(5)); 
    }

    public void GoToMainMenu()
    {
        StartCoroutine(LoadSceneWithDelay(0));
    }

    public void GoToLevelSequence()
    {
       StartCoroutine(LoadSceneWithDelay(1));
    }

    public void ExitGame()
    {
        Application.Quit(); 
    }

     private IEnumerator LoadSceneWithDelay(int scene)
    {  
       yield return new WaitForSeconds(1);
       SceneManager.LoadScene(scene);
    }
}

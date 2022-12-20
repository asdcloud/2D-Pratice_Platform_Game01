using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SMeneger : MonoBehaviour
{
    
    public void PlayGame()
    {
        //呼叫第一場景
        SceneManager.LoadScene("SampleScene");
        score.scoreValue = 0;
    }

    public void RestartGame()
    {
        //呼叫第一場景
        SceneManager.LoadScene("SampleScene");
        score.scoreValue = 0;
    }

    public void QuitGame()
    {
        //離開遊戲
        Application.Quit();
    }

    public void GameOver()
    {
        SceneManager.LoadScene("UI 2");
    }

    public void menu()
    {
        SceneManager.LoadScene("UI 1");
    }
}

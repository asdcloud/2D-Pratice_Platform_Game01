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
    }

    public void RestartGame()
    {
        //呼叫第一場景
        SceneManager.LoadScene("UI 1");
    }

    public void QuitGame()
    {
        //離開遊戲
        Application.Quit("UI 1");
    }
}

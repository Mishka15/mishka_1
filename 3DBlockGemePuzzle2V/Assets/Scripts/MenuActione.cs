using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuA : MonoBehaviour
{
    public void StartGame(){SceneManager.LoadScene("Level");}

    public void BackToMenu(){SceneManager.LoadScene("Menu");}

    public void Levels(){SceneManager.LoadScene("Levels");}

    public void ExitGame()
    {
        Debug.Log("Exit game now!");
        Application.Quit();

    }
    public void RestartLevel(){SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);}

    public void ChooseLevel(int x){SceneManager.LoadScene(x);   }
}
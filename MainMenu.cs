using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }  

    public void QuitGame()
    {
        Application.Quit(); 
    }

    public void StoryScene()
    {
        SceneManager.LoadScene("Story_Scene");
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene("Settings_Scene");
    }

    public void CloseSettings()
    {
        SceneManager.LoadScene("Main_menu");
    }

}

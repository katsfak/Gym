using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
     public GameObject onLineHelp;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Settings_button()
    {
        SceneManager.LoadScene("Settings");

    }

  public void OnLineHelp()
{
    
        onLineHelp.SetActive(true);
}

    public void GoToMainMenu()
    {
        Time.timeScale = 1f; // Resume time before switching scenes
        SceneManager.LoadScene("Main Menu");
    }


    public void Exit_button()
    {
        SceneManager.LoadScene("Exit");

    }
}
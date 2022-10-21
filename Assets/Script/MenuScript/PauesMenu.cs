using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauesMenu : MonoBehaviour
{
    public static bool GameIsPause;
    public GameObject pauseMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (GameIsPause)
        {
            Resume();
        }
        else
        {
            Pause();
        }
       
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        GameIsPause = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0.0f;
        GameIsPause = true;
    }

    public void MainMenu()
    {
        Time.timeScale = 1.0f;
        GameIsPause = false;
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartGame()
    {
        Time.timeScale = 1.0f;
        GameIsPause = false;
        SceneManager.LoadScene("PauseMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject PauseMenu;


    public void Play()

    {
        Time.timeScale = 1;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {

        Application.Quit();
    }

    public void pausebutton()
    {

        if (GameIsPause)
        {
            resume();
        }
        else if (!GameIsPause)
        {
            pause();
        }
    }
    public void resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
        GameIsPause = false;

    }
    public void pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
        GameIsPause = true;

    }

    public void menu()
    {
        GameIsPause = false;
        SceneManager.LoadScene("menu");

    }
    public void restart()
    {

        SceneManager.LoadScene(1);

    }
   
}


using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using SimpleFPS;

public class PauseGame : MonoBehaviour
{
    public FirstPersonController firstPerson;
    public static bool GameIsPause = false;

    public GameObject pauseMenuUI;

    
    void Update()
    {
         
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            if (GameIsPause)
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
        Cursor.visible = false;
        pauseMenuUI.SetActive(false);
        GameIsPause = false;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        firstPerson.enabled = true;

    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        GameIsPause = true;
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
       firstPerson.enabled = false;
    }
    public void LoadMainMenu()
    {
        Cursor.visible = true;
        Time.timeScale = 1f;
        
        SceneManager.LoadScene(0);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}

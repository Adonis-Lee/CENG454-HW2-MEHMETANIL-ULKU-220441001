using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject mainMenuPanel;
    public GameObject gameOverPanel;
    public GameObject gamePlayPanel;
    
    void Start()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        Time.timeScale = 0f;
        mainMenuPanel.SetActive(true);
        AudioListener.pause = true;
        gameOverPanel.SetActive(false);
        if (gamePlayPanel != null) gamePlayPanel.SetActive(false);
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        mainMenuPanel.SetActive(false);
        gameOverPanel.SetActive(false);
        if (gamePlayPanel != null) gamePlayPanel.SetActive(true);
    }
    
    public void TriggerGameOver()
    {
        Time.timeScale = 0f;
        gameOverPanel.SetActive(true);
        if (gamePlayPanel != null) gamePlayPanel.SetActive(false);
        AudioListener.pause = true;
    }
    
    public void RetryGame()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Debug.Log("Quiting Game...");
        Application.Quit();
    }
}

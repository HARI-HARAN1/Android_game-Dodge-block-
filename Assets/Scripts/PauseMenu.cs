using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject resumeButton;
    public GameObject quitButton;

    private bool isPaused = false;

    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        pauseButton.SetActive(false);
        resumeButton.SetActive(true);
        quitButton.SetActive(true);
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;
        pauseButton.SetActive(true);
        resumeButton.SetActive(false);
        quitButton.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit(); // On Android, this closes the app
        Debug.Log("Quit");  // Just to see something in Editor
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] int _mainMenu = 0;
    [SerializeField] Canvas _canvas;

    public void OpenMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(_mainMenu);
    }
    
    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void ContinueGame()
    {
        Time.timeScale = 1;
        _canvas.enabled = false;
    }
    
    public void PauseGame() 
    {
        Time.timeScale = 0;
        _canvas.enabled = true;
    }
}

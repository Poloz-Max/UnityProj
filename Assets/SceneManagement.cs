using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    private string _currentSceneName;
    public GameObject VictoryCanvas;
    private void Start()
    {
        _currentSceneName = SceneManager.GetActiveScene().name;
        if (VictoryCanvas != null)
            VictoryCanvas.SetActive(false);
    }

    public void RestartScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(_currentSceneName);
    }

    public void ReturnToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu"); 
    }
}

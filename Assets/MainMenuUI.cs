using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject aboutPanel;

    // Відкрити ігрову сцену
    public void PlayGame()
    {
        SceneManager.LoadScene("Run and Obtain!"); 
    }

    // Перейти до підменю "Про гру"
    public void ShowAbout()
    {
        mainMenuPanel.SetActive(false);
        aboutPanel.SetActive(true);
    }

    // Повернутись до головного меню
    public void BackToMenu()
    {
        aboutPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    // Вийти з гри
    public void QuitGame()
    {
        Application.Quit();
    }
}

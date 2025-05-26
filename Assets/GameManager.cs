using UnityEngine;

public class GameManager : MonoBehaviour

{
    public static GameManager Instance;

    public GameObject VictoryCanvas;
    private int totalSpheres = 4; 
    private int collectedSpheres = 0;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        if (VictoryCanvas == null)
            VictoryCanvas = GameObject.Find("VictoryCanvas"); 
    }

    void Start()
    {
        if (VictoryCanvas != null)
            VictoryCanvas.SetActive(false);  
    }

    public void RegisterSphereTouched()
    {
        collectedSpheres++;
        Debug.Log($"Куля зібрана. {collectedSpheres}/{totalSpheres}");

        if (collectedSpheres >= totalSpheres)
        {
            ShowVictory();
        }
    }

    void ShowVictory()
    {
        Debug.Log("Всі кулі зібрано!");
        if (VictoryCanvas != null)
        {
            VictoryCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            Debug.LogError("victoryCanvas == null!");
        }
    }
}

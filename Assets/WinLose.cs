using UnityEngine;

public class WinLose : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void WinLevel()
    {
        Debug.Log("You win!");
    }

    // Update is called once per frame
    public void LoseLevel()
    {
        Debug.Log("You lose!");
    }
}

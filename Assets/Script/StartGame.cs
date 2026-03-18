using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject startPanel;

    private static bool gameStarted = false;

    void Start()
    {
        if (!gameStarted)
        {
            Time.timeScale = 0f;
            startPanel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;
            startPanel.SetActive(false);
        }
    }

    public void StartButton()
    {
        gameStarted = true;
        startPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
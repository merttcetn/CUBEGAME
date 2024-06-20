using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        // Show level complete ui
        completeLevelUI.SetActive(true);
    }
    public void EndGame() {
        if (!gameEnded)
        {
            gameEnded = true;
            Invoke(nameof(RestartGame), restartDelay);
        }
    }

    void RestartGame()
    {
        // loads next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

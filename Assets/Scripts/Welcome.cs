using UnityEngine;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level01"); // hardcoded!
    }
}

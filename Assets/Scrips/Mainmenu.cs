using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Scenc1");
    }

    public void Exit()
    {
        Application.Quit();
    }
}

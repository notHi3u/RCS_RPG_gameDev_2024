using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Setting : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

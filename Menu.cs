using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    [SerializeField] Button Resume;

    [SerializeField] Button Options;

    [SerializeField] Button Restart;

    [SerializeField] Button QuitGame;

    [SerializeField] int sceneIndex;

    private void Awake() {
        Resume.onClick.AddListener(StartGame);
        Options.onClick.AddListener(OptionMenu);
        Restart.onClick.AddListener(RestartGame);
        QuitGame.onClick.AddListener(Quit);        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void OptionMenu()
    {
        SceneManager.LoadScene("Options");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Scene1");
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
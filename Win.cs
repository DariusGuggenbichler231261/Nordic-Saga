using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{

    [SerializeField] Button Restart;

    [SerializeField] Button QuitGame;

    [SerializeField] int sceneIndex;

    private void Awake() {
        Restart.onClick.AddListener(RestartGame);
        QuitGame.onClick.AddListener(Quit);        
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
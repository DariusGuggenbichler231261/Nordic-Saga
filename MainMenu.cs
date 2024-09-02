using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour 
{


    [SerializeField] Button LoadGame;

    [SerializeField] Button QuitGame;

    [SerializeField] int sceneIndex;

    private void Awake() {
        LoadGame.onClick.AddListener(StartGame);
        QuitGame.onClick.AddListener(Quit);        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(sceneIndex);
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
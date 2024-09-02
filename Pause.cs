using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Pause : MonoBehaviour 
{

    [SerializeField] Button Menu;


    private void Awake() {
        Menu.onClick.AddListener(PauseScreen);        
    }

    public void PauseScreen()
    {
        SceneManager.LoadScene("Menu");
    }
}
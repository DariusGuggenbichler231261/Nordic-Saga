using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   [SerializeField] int sceneindex;
   private void OnTriggerEnter(Collider other) {
    SceneManager.LoadScene(sceneindex);
   } 
}

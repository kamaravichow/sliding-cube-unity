
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelComplete : MonoBehaviour
{
    public void LoadNextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

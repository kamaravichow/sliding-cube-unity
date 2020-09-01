
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 2f;

    public GameObject CompleteLevelUI;

    public void CompleteLevel(){
        Debug.Log("Level Completed");
        CompleteLevelUI.SetActive(true);
    }


    public void EndGame(){
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

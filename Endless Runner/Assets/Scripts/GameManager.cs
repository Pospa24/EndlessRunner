using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameEnded = false;
    float restartDelay = 1.5f;
    public GameObject completeLevelUI;

    public void EndGame()
    {
        if(gameEnded == false)
        {
            Debug.Log("Game Over!");
            Invoke("RestartGame", restartDelay);
            gameEnded = true;
        }
        
    }
    
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    
    public bool getGameEnded()
    {
        return gameEnded;
    }
}

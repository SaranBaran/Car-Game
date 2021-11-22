using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float delay = 1f;

    public static GameManager gameManager;

    public GameObject completeLevelUI;

    public void Awake()
    {
        gameManager = this;
    }
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", delay);
        }
        Debug.Log("19 dollar fornite card");
    }    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
 
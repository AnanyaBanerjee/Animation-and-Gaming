using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUIMine;

    public void EndGame()
    {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            //Restart the game
            Invoke("Restart", restartDelay);
        }
    }

    public void completeMyLevel()
    {
        Debug.Log("Level Completed");
        completeLevelUIMine.SetActive(true);

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

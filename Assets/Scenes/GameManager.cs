using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{// Game manager for handling lose/win screens
    bool endGame = false;
    bool victory = false;
    public float restartDelay = 3f;
    public void GameOver()
    {
       if (endGame == false)
        {
            endGame = true;
            Debug.Log("Game Over");
            Invoke("Loss", restartDelay);
        }
        
    }

    public void Winner()
    {
        if (victory == false)
        {
            victory = true;
            Debug.Log("You Win!!!");
            Invoke("Restart", restartDelay);
        }
    }
    void Loss ()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Lose");
    }

    void Restart()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Win");
    }
}


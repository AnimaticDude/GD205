using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
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
        SceneManager.LoadScene("Lose");
    }

    void Restart()
    {
        SceneManager.LoadScene("Win");
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace GT
{
    public class PausMenu : MonoBehaviour
    {
        public int i = 0;
        public bool PausedGame = false;
        

        public GameObject pauseMenuUI;


        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                    if (PausedGame)
                    {
                        Resume();
                    }
                    else
                    {
                        Pause();
                    }
                }
            }
       

        public void Resume()
        {
            //Resumes the game, time returns to normal
            Cursor.lockState = CursorLockMode.Locked;
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            PausedGame = false;

        }

        public void Pause()
        {
            //Pauses the game, time stops
            Cursor.lockState = CursorLockMode.None;
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            PausedGame = true;
        }

        public void LoadMenu()
        {
            //Loads the Main Menu Scene
            Resume();
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("Main Menu");
        }

        public void QuitGame()
        {
            //Quits the game when built
            Resume();
            Cursor.lockState = CursorLockMode.None;
            Debug.Log("Exiting game....");
            Application.Quit();
        }
    }
}

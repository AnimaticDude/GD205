using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.InputSystem.UI;

namespace GT
{
    public class MainMenu : MonoBehaviour
    {

        public void PlayGame()
        {
            //Loads the Main Game scene
            SceneManager.LoadScene("Programmer Cupid");
        }

        public void QuitGame()
        {
            //Quits the game when built
            Debug.Log("Quit");
            Application.Quit();
        }
    }
}
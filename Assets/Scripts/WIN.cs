using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GT
{
    public class WIN : MonoBehaviour
    {

        public void PlayGame()
        {
            //Calls game scene
            SceneManager.LoadScene("Programmer Cupid");
        }

        public void MainMenu()
        {
            //calls main menu
            SceneManager.LoadScene("Main Menu"); ;
        }
    }
}
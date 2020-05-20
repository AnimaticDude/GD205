using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 180f; //3 minute timer

    [SerializeField]
    Text countdownText;
    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0"); //makes countdown text

        if (currentTime <= 0) //if timer reaches 0 load lose screen
        {
            currentTime = 0;
            Lose();
        }

        if (currentTime >= 15f) //default text color
        { 
            countdownText.color = Color.white; 
        }

        if (currentTime < 15f) //change text color below certain threshold
        { 
            countdownText.color = Color.red; 
        }
        
        if (DateCount.scoreValue == 8) //pairing 4 couples load win screen
        {
            Win();
        }
    }
    void Win() //loads win scene
    {
        DateCount.scoreValue = 0;
        Debug.Log("Way to go Cupid!");
        FindObjectOfType<GameManager>().Winner();
    }

    void Lose() //loads lose scene
    {
        Debug.Log("Ran out of time!");
        DateCount.scoreValue = 0;
        FindObjectOfType<GameManager>().GameOver();
    }
}

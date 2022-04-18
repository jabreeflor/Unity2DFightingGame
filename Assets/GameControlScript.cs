using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControlScript : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, gameOver;
    public GameObject player2Heart1, player2Heart2, player2Heart3,gameOverButton;
    public static int health, player2Health;
    
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        player2Health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);

        player2Heart1.gameObject.SetActive(true);
        player2Heart2.gameObject.SetActive(true);
        player2Heart3.gameObject.SetActive(true);

        gameOver.gameObject.SetActive(false);
        gameOverButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
            health = 3;
        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                
                gameOver.gameObject.SetActive(true);
                gameOverButton.gameObject.SetActive(true);
                Time.timeScale = 0f;
                break;
        }

        if (player2Health > 3)
            player2Health = 3;
        switch (player2Health)
        {
            case 3:
                player2Heart1.gameObject.SetActive(true);
                player2Heart2.gameObject.SetActive(true);
                player2Heart3.gameObject.SetActive(true);
               
                break;
            case 2:
                player2Heart1.gameObject.SetActive(true);
                player2Heart2.gameObject.SetActive(true);
                player2Heart3.gameObject.SetActive(false);
               
                break;
            case 1:
                player2Heart1.gameObject.SetActive(true);
                player2Heart2.gameObject.SetActive(false);
                player2Heart3.gameObject.SetActive(false);
                
                break;
            case 0:
                player2Heart1.gameObject.SetActive(false);
                player2Heart2.gameObject.SetActive(false);
                player2Heart3.gameObject.SetActive(false);
                
                gameOver.gameObject.SetActive(true);
                gameOverButton.gameObject.SetActive(true);
                Time.timeScale = 0f;
                break;
        }

    }
}

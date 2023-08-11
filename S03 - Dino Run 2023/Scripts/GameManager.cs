using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    public static GameManager instance;


    public GameObject obstacleSpawner;
    public GameObject gameOverPanel;

    int score = 0;

    public TextMeshProUGUI scoreText;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }


    public void GameOver()
    {
        StopScrolling();
        StopObstacles();

        obstacleSpawner.SetActive(false);

        gameOverPanel.SetActive(true);

    }

    void StopScrolling()
    {
        TextureScroll[] scrollingObjects = FindObjectsByType<TextureScroll>(FindObjectsSortMode.None);
    
        foreach(TextureScroll t in scrollingObjects)
        {
            t.scroll = false;


        }
    
    
    }

    void StopObstacles()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");

        foreach(GameObject o in obstacles)
        {
            o.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }

    public void IncrementScore()
    {
        score++;

        scoreText.text = score.ToString();

    }


    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }




}

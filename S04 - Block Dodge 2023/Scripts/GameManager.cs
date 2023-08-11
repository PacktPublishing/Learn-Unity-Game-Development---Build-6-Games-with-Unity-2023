using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject block;
    public float maxX;
    public Transform spawnPoint;
    public float spawnRate;

    public GameObject tapText;
    bool gameStarted = false;
    public TextMeshProUGUI scoreText;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !gameStarted) { 
            
            StartSpawning();
            gameStarted = true;  
            tapText.SetActive(false);
        }
    }

    void StartSpawning()
    {
        InvokeRepeating("SpawnBlock", 0.5f, spawnRate);
    }

    void SpawnBlock()
    {
        Vector3 spawnPos = spawnPoint.position; 
        spawnPos.x = Random.Range(-maxX, maxX);

        Instantiate( block, spawnPos, Quaternion.identity );
        score++;
        scoreText.text = score.ToString();
        
    }

}

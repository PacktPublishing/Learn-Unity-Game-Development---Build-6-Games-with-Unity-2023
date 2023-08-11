using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{

    public GameObject obstacle;
    public Transform spawnPoint;
    public TextMeshProUGUI scoreText;
    int score;
    public GameObject player;
    public GameObject playButton;
    // Start is called before the first frame update
    void Start()
    {
        //GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator SpawnObstacle()
    {

        while (true)
        {
            float waitTime = Random.Range(0.5f, 2);

            yield return new WaitForSeconds(waitTime);

            Instantiate(obstacle, spawnPoint.position, Quaternion.identity);
        }

    }

    //IEnumerator ScoreUp()
    //{

    //    yield return new WaitForSeconds(1f);

    //    while (!gameOver)
    //    {
    //        yield return new WaitForSeconds(1f);
    //        score++;
    //        scoreText.text = score.ToString();
    //    }



    //}

    void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
    }


    public void GameStart()
    {
        player.SetActive(true);
        playButton.SetActive(false);

        StartCoroutine("SpawnObstacle");
        //StartCoroutine("ScoreUp");
        InvokeRepeating("ScoreUp", 2f, 1f);
        
    }



}

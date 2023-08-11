using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject[] obstacles;

    public float minSpawnTime, maxSpawnTime;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Spawn");
    }


    IEnumerator Spawn()
    {
        float waitTime = 1f;

        yield return new WaitForSeconds(waitTime);

        while (true)
        {
            
            SpawnObstacle();


            waitTime = Random.Range(minSpawnTime, maxSpawnTime);

            yield return new WaitForSeconds(waitTime);
        }



    }



    void SpawnObstacle()
    {

        int random = Random.Range(0, obstacles.Length);

        Instantiate(obstacles[random], transform.position, Quaternion.identity); 

    }

}

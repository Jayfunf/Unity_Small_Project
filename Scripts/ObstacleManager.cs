using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{

    public GameObject obstacleNor;
    public GameObject obstacleSet;

    public float productionTime;
    public GameObject Player;

    void Start()
    {
        StartCoroutine("ObstaclePro");
    }

    void Update()
    {
    }

    IEnumerator ObstaclePro()
    {
        Obstacle();
        yield return new WaitForSeconds(productionTime);
        StartCoroutine("ObstaclePro");
    }
    void Obstacle()
    {
        GameObject obstacle = Instantiate(obstacleNor) as GameObject;
        obstacle.transform.parent = obstacleSet.transform;
        obstacle.transform.position = new Vector3(Random.Range(-2.2f, 2.2f), transform.position.y, 0);
    }
}



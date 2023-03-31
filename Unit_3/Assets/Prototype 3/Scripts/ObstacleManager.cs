using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public PlayerController playerControllerScript;
    private Vector3 obstaclePos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float startRate = 2;
    private int randomObstacle;
    void Start()
    {
        InvokeRepeating("CreateObstacle", startDelay, startRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void CreateObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            randomObstacle = Random.Range(0, obstaclePrefabs.Length);
            Instantiate(obstaclePrefabs[randomObstacle], obstaclePos, obstaclePrefabs[randomObstacle].transform.rotation);
        }
    }
}

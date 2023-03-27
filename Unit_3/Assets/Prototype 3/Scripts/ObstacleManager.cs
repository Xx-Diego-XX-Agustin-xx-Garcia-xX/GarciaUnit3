using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 obstaclePos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float startRate = 2;
    public PlayerController playerControllerScript;
    void Start()
    {
        InvokeRepeating("CreateObstacle", startDelay, startRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void CreateObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, obstaclePos, obstaclePrefab.transform.rotation);
        }
    }
}

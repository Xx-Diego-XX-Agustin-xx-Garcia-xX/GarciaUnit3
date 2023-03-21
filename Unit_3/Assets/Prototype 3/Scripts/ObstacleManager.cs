using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 obstaclePos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float startRate = 2;
    void Start()
    {
        InvokeRepeating("CreateObstacle", startDelay, startRate);
    }
    void CreateObstacle()
    {
        Instantiate(obstaclePrefab, obstaclePos, obstaclePrefab.transform.rotation);
    }
}

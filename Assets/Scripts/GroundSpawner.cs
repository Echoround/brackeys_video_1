using UnityEngine;
using System.Collections.Generic;
using System;

public class GroundSpawner : MonoBehaviour
{

    [SerializeField] GameObject groundTile;
    [SerializeField] GameObject obstaclePrefab;
    Vector3 nextSpawnPoint;
    public List<GameObject> tileList = new List<GameObject>();
    public bool spawnItems;

    public void SpawnTile(bool spawnItems)
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        tileList.Add(temp);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;



        if (spawnItems)
        {
            //temp.GetComponent<GroundTile>().SpawnObstacle();
            temp.GetComponent<GroundTile>().SpawnObstacle();
            // temp.GetComponent<GroundTile>().SpawnCoins();
        }
    }
    private void Start()
    {
        for (int i = 0; i < 7; i++)
        {
            if (i < 3)
            {
                SpawnTile(false);
            }
            else
            {
                SpawnTile(true);
            }
        }
    }

    public void RemoveOldTiles(GameObject tile)
    {
        for (int i = 0; i < tileList.Count; i++)
        {
            
        }
    }



}


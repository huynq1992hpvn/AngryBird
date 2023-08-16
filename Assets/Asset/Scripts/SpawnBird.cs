using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnBird : MonoBehaviour
{
    public Level level;
    public GameObject BirdCopy;
    public Transform spawnLocation;
    private float delayPerSpawn = 5;
    private float currentTimeSpawn = 0;
    private void Start()
    {
        SpawnBird1();
        

    }
    private void Update()
    {
        //if (level.EnemyAlive == true)
        //{
            if (currentTimeSpawn >delayPerSpawn)
            {
                currentTimeSpawn = 0;
                SpawnBird1 ();
            }
            currentTimeSpawn += Time.deltaTime;
        //}
    }
    
    private void SpawnBird1()
    {
        GameObject bird = Instantiate(BirdCopy);
        bird.transform.position = spawnLocation.position;
    }

}

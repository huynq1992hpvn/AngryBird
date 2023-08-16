using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public bool EnemyAlive;
    private static int nextLevelIndex = 1;
    private Enemy[] enemies;

    private void OnEnable()
    {
        enemies =FindObjectsOfType<Enemy>();
    }
    private void Update()
    {
        
        foreach (Enemy enemy in enemies)
        {
            if (enemy != null)
            {
                
                return;
                
            }           
            
        }
        Debug.Log("You killed all Enemy");
        nextLevelIndex++;
        if ( nextLevelIndex == 4)
        {
            SceneManager.LoadScene("Endgame");
        }
        else
        {
            string nextLevelName = "Level " + nextLevelIndex;

            SceneManager.LoadScene(nextLevelName);
        }
    }
}

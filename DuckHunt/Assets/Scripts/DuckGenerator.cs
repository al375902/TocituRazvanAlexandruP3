using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckGenerator : MonoBehaviour
{
    public float spawnTime = 3f;
    public GameObject duck;
    private MovementDuck duckScript;
  

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Spawn()
    {
        int leftOrRight = Random.Range(0, 10);
        Debug.Log(leftOrRight);
        
        if( leftOrRight > 5)
        {
            int spawnPointY = Random.Range(-2, 5);
            Vector3 spawnPosition = new Vector3(-22.44f, spawnPointY, -2f);
            Instantiate(duck, spawnPosition, Quaternion.identity);
        }
        else
        {
            int spawnPointY = Random.Range(-2, 5);
            Vector3 spawnPosition = new Vector3(-2.7f, spawnPointY, -2f);
            Instantiate(duck, spawnPosition, Quaternion.identity);
        }

        
    }

}

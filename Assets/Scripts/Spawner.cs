using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obj;
    private float randX;
    private float randY;
    Vector2 wheretospawn;
    public float SpawnDelay;
    float NextSpawn = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > NextSpawn)
        {
            NextSpawn = Time.time + SpawnDelay;
            randX = Random.Range(-20, 20);
            randY = Random.Range(-15, 15);
            wheretospawn = new Vector2(randX, randY);
            if ((wheretospawn != null)&&(obj!=null))
            {
                GameObject heal = Instantiate(obj, wheretospawn, Quaternion.identity);
            }
           // Destroy(heal, 5f);
        }
    }
}

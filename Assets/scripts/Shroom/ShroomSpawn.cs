using System.Runtime.CompilerServices;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShroomSpawn : MonoBehaviour
{
    public GameObject Shrooms11;
    public GameObject Shrooms13;
    public GameObject Shrooms10;
    public Transform spawnPoint;
    public GameObject varmanagerobj;
    public float maxX;
    public float maxZ;
    public float minShroomId;
    public float maxShroomId;
    public float generatedShroomid;
    public float ShroomLimiter;
    public float MaxShrooms;
    // Start is called before the first frame update
    void Start()
    {
        SpawnShroom();
        SpawnShroom();
        SpawnShroom();
        SpawnShroom();
        SpawnShroom();
        SpawnShroom();
        SpawnShroom();
        SpawnShroom();
        SpawnShroom();
        SpawnShroom();
        SpawnShroom();
        SpawnShroom();
        SpawnShroom();
        SpawnShroom();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnShroom();
    }





    void SpawnShroom()
    {
        float randomX = Random.Range(-maxX, maxX);
        float randomZ = Random.Range(-maxZ, maxZ);

        float generatedShroomid = Random.Range(minShroomId, maxShroomId);
        Vector3 randomSpawnPos = new Vector3(randomX, 40, randomZ);
        if (ShroomLimiter < MaxShrooms){
        if (generatedShroomid < 1 || generatedShroomid == 1)
        {
            Debug.Log("spawning shroom 11");
            Instantiate(Shrooms11, randomSpawnPos, Quaternion.identity);
        }
        else if(generatedShroomid== 2 || generatedShroomid > 2 && generatedShroomid < 3)
        {
            Debug.Log("spawning shroom 10");
            Instantiate(Shrooms10, randomSpawnPos, Quaternion.identity);
            float ShroomLimiter =+ 1;
        }
        else if(generatedShroomid== 3 || generatedShroomid > 3 && generatedShroomid < 4)
        {
            Debug.Log("Not Spawning Any Shroom");
        }
        else if(generatedShroomid== 4 || generatedShroomid > 4 && generatedShroomid < 5)
        {
            Debug.Log("Not Spawning Any Shroom");
        }
        else if(generatedShroomid== 5 || generatedShroomid > 5 && generatedShroomid < 6)
        {
            Debug.Log("spawning shroom 13");
            Instantiate(Shrooms13, randomSpawnPos, Quaternion.identity);
            float ShroomLimiter =+ 1;
        }
        else if(generatedShroomid== 6 || generatedShroomid > 6 && generatedShroomid < 7)
        {
            Debug.Log("spawning shroom 11");
            Instantiate(Shrooms11, randomSpawnPos, Quaternion.identity);
            float ShroomLimiter =+ 1;
        }
        else if(generatedShroomid== 7 || generatedShroomid > 7 && generatedShroomid < 8)
        {
            Debug.Log("Not Spawning Any Shroom");
        }
        else if(generatedShroomid== 8 || generatedShroomid > 8 && generatedShroomid < 9)
        {
            Debug.Log("Not Spawning Any Shroom");
        }     
        else if(generatedShroomid== 9 || generatedShroomid > 9 && generatedShroomid < 10)
        {
            Debug.Log("spawning shroom 13");
            Instantiate(Shrooms13, randomSpawnPos, Quaternion.identity);
            float ShroomLimiter =+ 1;
        }   
        else if(generatedShroomid== 10 || generatedShroomid > 10 && generatedShroomid < 11)
        {
            Debug.Log("spawning shroom 11");
            Instantiate(Shrooms11, randomSpawnPos, Quaternion.identity);
            float ShroomLimiter =+ 1;
        }
        else if(generatedShroomid== 11 || generatedShroomid > 11 && generatedShroomid < 12)
        {
            Debug.Log("Not Spawning Any Shroom");
        }
        else if(generatedShroomid== 12 || generatedShroomid > 12 && generatedShroomid < 13)
        {
            Debug.Log("Not Spawning Any Shroom");
        }
        else if(generatedShroomid== 13 || generatedShroomid > 13 && generatedShroomid < 14)
        {
            Debug.Log("Not Spawning Any Shroom");
        }
        else if(generatedShroomid== 14 || generatedShroomid > 14 && generatedShroomid < 15)
        {
            Debug.Log("Not Spawning Any Shroom");
        }
        else if(generatedShroomid== 15 || generatedShroomid > 15 && generatedShroomid < 16)
        {
            Debug.Log("Not Spawning Any Shroom");
        }
        else
        {
            
        }
        }

    }
}

using System.Runtime.CompilerServices;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TreeSpawn : MonoBehaviour
{
    public Transform spawnPoint;
    public float maxX;
    public float maxZ;
    public GameObject Tree1;
    // Start is called before the first frame update
    void Start()
    {
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();        
        SpawnTree();         
    }

    // Update is called once per frame
    void Update()
    {
        
    }





    void SpawnTree()
    {
        float randomX = Random.Range(-maxX, maxX);
        float randomZ = Random.Range(-maxZ, maxZ);

        Vector3 randomSpawnPos = new Vector3(randomX, 40, randomZ);
        
        Instantiate(Tree1, randomSpawnPos, Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shroom13Main : MonoBehaviour
{
    Rigidbody rb;
    public float MAINshroomINinv1;
    public GameObject Shroom11Inv;
    public GameObject Shroom13Inv;
    public GameObject Shroom10Inv;
    public GameObject SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPoint.GetComponent<ShroomSpawn>().ShroomLimiter += 1; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Shroom11Inv.active=false;
        Shroom13Inv.active=true;
        Shroom10Inv.active=false;
        gameObject.active=false;
        SpawnPoint.GetComponent<ShroomSpawn>().ShroomLimiter -= 1;
    }
     void OnCollisionEnter(Collision collision) {

         if (collision.gameObject.name == "Terrain")
         {
            rb.constraints = RigidbodyConstraints.FreezeAll;
         }
     }
}

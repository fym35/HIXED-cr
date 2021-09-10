using Microsoft.Win32.SafeHandles;
using System.Runtime.ExceptionServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shroom11Main : MonoBehaviour
{
    Rigidbody rb;
    public float MAINshroomINinv;
    public GameObject varmanagerobj;
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
        Shroom13Inv.active=false;
        Shroom10Inv.active=false;
        Shroom11Inv.active=true;
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

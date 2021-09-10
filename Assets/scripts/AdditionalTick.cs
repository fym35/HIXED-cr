using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionalTick : MonoBehaviour
{
    public GameObject varmanager;
    public GameObject ShroomFactoryInvObj; 
    public GameObject SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        varmanager.GetComponent<VarManagerMainScript>().TimeToDecHealth += 1;
        if(varmanager.GetComponent<VarManagerMainScript>().TimeToDecHealth > 950)
        {
            Debug.Log("Decreased Health");
            varmanager.GetComponent<VarManagerMainScript>().Health -= 1;            
            varmanager.GetComponent<VarManagerMainScript>().TimeToDecHealth = 0;
        }
    }

    void OnMouseDown()
    {
        if(ShroomFactoryInvObj.active)
        {
            SpawnPoint.GetComponent<APlTick>().ToPlaceSFC = 1;
        }
    }
}

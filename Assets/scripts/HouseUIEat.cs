using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseUIEat : MonoBehaviour
{
    public GameObject Shroom11Inv;
    public GameObject Shroom13Inv;
    public GameObject Shroom10Inv;
    public GameObject varmanager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
             if(Shroom11Inv.activeSelf)
             {
                varmanager.GetComponent<VarManagerMainScript>().Health += 6;
                Shroom11Inv.active = false;
             }
            if(Shroom13Inv.active)
             {
                varmanager.GetComponent<VarManagerMainScript>().Health -= 2;
                Shroom13Inv.active=false;
             }
            if(Shroom10Inv.active)
             {
                varmanager.GetComponent<VarManagerMainScript>().Health += 8;
                Shroom10Inv.active=false;
             }        
        }
    }

    private void OnMouseDown()
    {
             if(Shroom11Inv.active)
             {
                varmanager.GetComponent<VarManagerMainScript>().Health += 4;
                Shroom11Inv.active=false;
             }
            if(Shroom13Inv.active)
             {
                varmanager.GetComponent<VarManagerMainScript>().Health -= 2;
                Shroom13Inv.active=false;
             } 
            if(Shroom10Inv.active)
             {
                varmanager.GetComponent<VarManagerMainScript>().Health += 8;
                Shroom10Inv.active=false;
             }        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HouseUISell : MonoBehaviour
{
    public GameObject varmanager;
    public GameObject Shroom11Inv;
    public GameObject Shroom13Inv;
    public GameObject Shroom10Inv;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
             if(Shroom11Inv.active)
             {
                varmanager.GetComponent<VarManagerMainScript>().Money += 4;
                Shroom11Inv.active = false;
             }
            if(Shroom13Inv.active)
             {
                varmanager.GetComponent<VarManagerMainScript>().Money += 3;
                Shroom13Inv.active=false;
             }
            if(Shroom10Inv.active)
             {
                varmanager.GetComponent<VarManagerMainScript>().Money += 10;
                Shroom10Inv.active=false;
             }        
        }
    }

    private void OnMouseDown()
    {
             if(Shroom11Inv.active)
             {
                varmanager.GetComponent<VarManagerMainScript>().Money += 4;
                Shroom11Inv.active=false;
             }
            if(Shroom13Inv.active)
             {
                varmanager.GetComponent<VarManagerMainScript>().Money += 3;
                Shroom13Inv.active=false;
             }     
            if(Shroom10Inv.active)
             {
                varmanager.GetComponent<VarManagerMainScript>().Money += 10;
                Shroom10Inv.active=false;
             }           
    }

    
}

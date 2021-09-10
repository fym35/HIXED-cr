using System.Runtime.ExceptionServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class HideHouseUI : MonoBehaviour
{
     public GameObject HouseUiParent;
     public GameObject HouseUiBackground;
     public GameObject HouseUiSellButton;
     public GameObject HouseUiEatButton;
     public GameObject HouseUiCloseButton;
    private void OnMouseDown()
    {
        HouseUiParent.active=false;
        HouseUiBackground.active=false;
        HouseUiSellButton.active=false;
        HouseUiEatButton.active=false;
        HouseUiCloseButton.active=false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("x"))
        {
            HouseUiParent.active=false;
            HouseUiBackground.active=false;
            HouseUiSellButton.active=false;
            HouseUiEatButton.active=false;
            HouseUiCloseButton.active=false;
        }
    }
    }



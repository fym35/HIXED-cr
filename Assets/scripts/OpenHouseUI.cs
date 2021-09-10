using System.Runtime.ExceptionServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class OpenHouseUI : MonoBehaviour
{
     public GameObject HouseUiParent;
     public GameObject HouseUiBackground;
     public GameObject HouseUiSellButton;
     public GameObject HouseUiEatButton;
     public GameObject HouseUiCloseButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        HouseUiParent.active=true;
        HouseUiBackground.active=true;
        HouseUiSellButton.active=true;
        HouseUiEatButton.active=true;
        HouseUiCloseButton.active=true;
    }
}

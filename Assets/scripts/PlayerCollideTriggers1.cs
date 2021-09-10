using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollideTriggers1 : MonoBehaviour
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
    void OnCollisionExit(Collision House4)
    {
            HouseUiParent.active=false;
            HouseUiBackground.active=false;
            HouseUiSellButton.active=false;
            HouseUiEatButton.active=false;
            HouseUiCloseButton.active=false;
    }
}
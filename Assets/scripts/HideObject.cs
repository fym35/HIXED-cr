using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Hide object until inital trigger
        gameObject.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

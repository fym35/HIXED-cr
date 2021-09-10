using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APlTick : MonoBehaviour
{
    public float ToPlaceSFC;
    public GameObject sfactory;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (ToPlaceSFC == 1)
       {
            Vector3 playerpos = Player.transform.position;
            Instantiate(sfactory, playerpos, Quaternion.identity);
            float ToPlaceSFC = 0;
       } 
    }
}

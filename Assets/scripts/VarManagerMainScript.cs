using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VarManagerMainScript : MonoBehaviour
{
    public float ShroomINinv;
    public Text Coins;
    public Text HTex;
    public float Money;
    public float Health;
    public float TimeToDecHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Coins.text = Money.ToString();
        HTex.text = Health.ToString();
        Debug.Log(TimeToDecHealth.ToString());
        if(Health == 0 || Health < 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }

    void ResetHealthDecDelay()
    {
        float TimeToDecHealth = 0;
    }
}

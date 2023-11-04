using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class CharacterBrain : MonoBehaviour
{
    public int health = 3;
    public Shoot shootScript;
    public TMP_Text healthText;


    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            GameManager.OnDeath();
        }
        healthText.text = "Health: " + health;

    }
}

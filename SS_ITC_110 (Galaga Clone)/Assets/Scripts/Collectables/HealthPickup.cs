using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterBrain charBrain = other.GetComponent<CharacterBrain>();
            if (charBrain != null) 
            {
                charBrain.health++;       
            }
            Destroy(this.gameObject);
        }
    }
}

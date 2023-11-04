using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            other.GetComponent<CharacterBrain>().health--;
    }
    public void Despawn()
    {
        Destroy(this.gameObject);
    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bulletPref;
    private Rigidbody2D rb;
    
    public void SpawnBullet(float speed, Vector2 dir)
    {
        GameObject bullet = Instantiate(bulletPref, transform);
        bullet.transform.localPosition = Vector3.zero;

        rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = dir * speed;
    }
}

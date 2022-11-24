using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playershooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public float bulletspeed = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            shoot();
        }
    }

    void shoot() {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletspeed, ForceMode2D.Impulse);
    }
}

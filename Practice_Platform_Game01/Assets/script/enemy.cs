using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    
    public float speed;
    private Transform playerPos;
    private playerhealth player;


    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<playerhealth>();
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update() {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }

    void OnCollisionEnter2D (Collision2D other) {
        if (other.gameObject.tag == "Player") {
            player.health--;
            Debug.Log(player.health);
            Destroy(gameObject);
        } else if (other.gameObject.tag == "bullet") {
            Destroy(gameObject);
        }
    }
}

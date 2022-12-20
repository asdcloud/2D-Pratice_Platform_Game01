using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    
    public float speed;
    private Transform playerPos;
    private playerhealth player;
    public GameObject boom_effect;


    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<playerhealth>();
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update() {
        if (player.health == 0) {
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }

    void OnCollisionEnter2D (Collision2D other) {
        if (other.gameObject.tag == "Player") {
            player.health--;
            Debug.Log(player.health);
            GameObject effect = Instantiate(boom_effect, transform.position, Quaternion.identity);
            Destroy(effect, 0.4f);
            Destroy(gameObject);
        } else if (other.gameObject.tag == "bullet") {
            score.scoreValue++;
            GameObject effect = Instantiate(boom_effect, transform.position, Quaternion.identity);
            Destroy(effect, 0.4f);
            Destroy(gameObject);
        }
    }
}

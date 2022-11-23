using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermov : MonoBehaviour
{
    private float moveInputx;
    private float moveInputy;
    private Rigidbody2D rb;
    public float speed;
    public Animator animator;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInputx = Input.GetAxisRaw("playermov-x");//
        moveInputy = Input.GetAxisRaw("playermov-y");//偵測玩家鍵盤輸入
        mov();
        faceMouse();
    }

    void mov() {
        rb.velocity = new Vector2(moveInputx * speed, moveInputy * speed);//移動
    }

    void faceMouse() {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

        transform.up = direction;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    private float MoveSpeed;
    public float offscreenDistance = -15f;


private void Awake()
{
    rb = GetComponent<Rigidbody2D>();
}

    void Update()
    {
        if (transform.position.x < offscreenDistance)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        if (!ObstacleSpawner.instance.gameOver)
        {
            rb.velocity = Vector2.left * MoveSpeed;
        }

        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
